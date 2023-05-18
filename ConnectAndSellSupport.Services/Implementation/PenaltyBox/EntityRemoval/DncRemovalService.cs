using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.TDnc;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval;
using ConnectAndSellSupport.Services.Contracts.User;
using ConnectAndSellSupport.Services.Extensions;
using ConnectAndSellSupport.Services.Helpers.TimeZone;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.PenaltyBox.EntityRemoval
{
    public class DncRemovalService : IEntityRemovalService
    {
        #region Private members
        private readonly ITDncRepository _tDncRepository;
        private readonly ITDncArchiveRepository _tDncArchiveRepository;
        private readonly INumberFetcher _numberFetcher;
        private readonly IUserFetcher _userFetcher;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public DncRemovalService(
            ITDncRepository tDncRepository,
            ITDncArchiveRepository tDncArchiveRepository,
            INumberFetcher numberFetcher,
            IUserFetcher userFetcher,
            IMapper mapper)
        {
            _tDncRepository = tDncRepository;
            _tDncArchiveRepository = tDncArchiveRepository; ;
            _numberFetcher = numberFetcher;
            _userFetcher = userFetcher;
            _mapper = mapper;
        }
        #endregion

        #region Private methods
        private async Task<(bool Success, int Count)> UpdateDnc(IEnumerable<TDnc> dncRecords)
        {
            if (dncRecords.IsNullOrEmpty())
            {
                return default;
            }

            // Move records to archive table
            var dncArchiveRecords = _mapper.Map<List<TDncArchive>>(dncRecords);

            var (userId, _) = await _userFetcher.GetLoggedInUser();

            dncArchiveRecords.ForEach(r =>
            {
                r.Id = default;
                r.ArchiveDate = TimeZoneHelper.GetPstTime();
                r.ArchiveUserId = userId;
            });

            await _tDncArchiveRepository.AddMultiAsync(dncArchiveRecords);

            await _tDncRepository.RemoveMultiAsync(dncRecords);

            return (true, dncRecords.Count());
        }
        #endregion

        #region Interface implementations
        public async Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(RemovePenaltyBoxEntityRequest entityRequest)
        {
            // If only company id filter is applied, fetch and update t_dnc numbers directly
            // else if user or list filter is applied, first get numbers from cas_contacts and then fetch and updadte t_dnc

            var dncRecords = new List<TDnc>();
            var numbersNotFound = new List<string>();
            if (entityRequest.UserIds.IsNullOrEmpty() && entityRequest.ListIds.IsNullOrEmpty())
            {
                dncRecords = (await _tDncRepository.GetByCompanyIdAndDateRange(
                    entityRequest.CompanyId, entityRequest.FromDate, entityRequest.ToDate)).ToList();
            }
            else
            {
                var phoneNumbers = await _numberFetcher.FetchFormattedNumbersFromContacts(entityRequest);

                if (phoneNumbers.Numbers.IsNullOrEmpty())
                {
                    return new RemovePenaltyBoxEntityServiceResponse
                    {
                        ContactsNotFound = true,
                        NumbersNotFound = phoneNumbers.DefaultedNumbers
                    };
                }

                numbersNotFound = phoneNumbers.DefaultedNumbers.ToList();
                
                dncRecords = (await _tDncRepository.GetByCompanyIdNumberListAndDateRange(
                    entityRequest.CompanyId, phoneNumbers.Numbers.ToHashSet(), entityRequest.FromDate, entityRequest.ToDate)).ToList();

                var dncRecordsNumbers = dncRecords.Select(d => d.ContactNumber);

                numbersNotFound.AddRange(phoneNumbers.Numbers.Except(dncRecordsNumbers));
            }

            var result = await UpdateDnc(dncRecords);

            return new RemovePenaltyBoxEntityServiceResponse
            {
                Success = result.Success,
                UpdatedCount = result.Count,
                NumbersNotFound = numbersNotFound
            };
        }

        public async Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(int companyId, List<RemovePenaltyBoxCsvRequest> entityRequests)
        {
            var phoneNumbers = await _numberFetcher.FetchFormattedNumbersFromContacts(entityRequests);

            if (phoneNumbers.Numbers.IsNullOrEmpty())
            {
                return new RemovePenaltyBoxEntityServiceResponse
                {
                    ContactsNotFound = true,
                    NumbersNotFound = phoneNumbers.DefaultedNumbers
                };
            }

            var numbersNotFound = phoneNumbers.DefaultedNumbers.ToList();

            var dncRecords = await _tDncRepository.GetByCompanyIdAndNumberList(companyId, phoneNumbers.Numbers.ToHashSet());

            var dncRecordsNumbers = dncRecords.Select(d => d.ContactNumber);

            numbersNotFound.AddRange(phoneNumbers.Numbers.Except(dncRecordsNumbers).ToList());

            var result = await UpdateDnc(dncRecords);

            return new RemovePenaltyBoxEntityServiceResponse
            {
                Success = result.Success,
                UpdatedCount = result.Count,
                NumbersNotFound = numbersNotFound
            };
        }
        #endregion
    }
}
