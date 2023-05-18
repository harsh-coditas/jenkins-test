using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasContact;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval;
using ConnectAndSellSupport.Services.Extensions;
using ConnectAndSellSupport.Services.Helpers.TimeZone;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.PenaltyBox.EntityRemoval
{
    public class MalformedNumberRemovalService : IEntityRemovalService
    {
        #region Private members
        private readonly IContactFetcher _contactFetcher;
        private readonly ICasContactRepository _casContactRepository;
        #endregion

        #region Constructor
        public MalformedNumberRemovalService(
            IContactFetcher contactFetcher,
            ICasContactRepository casContactRepository)
        {
            _contactFetcher = contactFetcher;
            _casContactRepository = casContactRepository;
        }
        #endregion

        #region Private methods
        private async Task<RemovePenaltyBoxEntityServiceResponse> UpdateMalformedNumberStatus(List<CasContact> malformedContacts)
        {
            if (malformedContacts.IsNullOrEmpty())
            {
                return new RemovePenaltyBoxEntityServiceResponse
                {
                    ContactsNotFound = true
                };
            }

            malformedContacts.ForEach(c =>
            {
                c.ContactStatus = null;
                c.LastModifiedDate = TimeZoneHelper.GetPstTime();
            });

            await _casContactRepository.UpdateMultiAsync(malformedContacts);

            return new RemovePenaltyBoxEntityServiceResponse
            {
                Success = true,
                UpdatedCount = malformedContacts.Count
            };
        }
        #endregion

        #region Interface implementations
        public async Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(RemovePenaltyBoxEntityRequest entityRequest)
        {
            var malformedContacts = await _contactFetcher.FetchContacts(entityRequest);

            return await UpdateMalformedNumberStatus(malformedContacts);
        }       

        public async Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(int companyId, List<RemovePenaltyBoxCsvRequest> entityRequests)
        {
            var malformedContacts = await _contactFetcher.FetchContacts(entityRequests);

            return await UpdateMalformedNumberStatus(malformedContacts);
        }
        #endregion
    }
}
