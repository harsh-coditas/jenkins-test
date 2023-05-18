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
    public class WrongNumberRemovalService : IEntityRemovalService
    {
        #region Private members
        private readonly IContactFetcher _contactFetcher;
        private readonly ICasContactRepository _casContactRepository;
        #endregion

        #region Constructor
        public WrongNumberRemovalService(
            IContactFetcher contactFetcher,
            ICasContactRepository casContactRepository)
        {
            _contactFetcher = contactFetcher;
            _casContactRepository = casContactRepository;
        }
        #endregion

        #region Private methods
        private async Task<RemovePenaltyBoxEntityServiceResponse> UpdateWrongNumberStatus(List<CasContact> contacts)
        {
            var wrongNumberedContacts = contacts?.FindAll(c =>
                c.Ienumbers?.Split(',').Length > 1);

            if (contacts.IsNullOrEmpty())
            {
                return new RemovePenaltyBoxEntityServiceResponse
                {
                    ContactsNotFound = true
                };
            }

            wrongNumberedContacts.ForEach(c =>
            {
                c.Ienumbers = null;
                c.WrongNumberPenaltyBoxEntryDate = null;
                c.LastModifiedDate = TimeZoneHelper.GetPstTime();
            });

            await _casContactRepository.UpdateMultiAsync(contacts);

            return new RemovePenaltyBoxEntityServiceResponse
            {
                Success = true,
                UpdatedCount = contacts.Count
            };
        }
        #endregion

        #region Interface implementations
        public async Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(RemovePenaltyBoxEntityRequest entityRequest)
        {
            var contacts = await _contactFetcher.FetchContacts(entityRequest);

            return await UpdateWrongNumberStatus(contacts);
        }

        public async Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(int companyId, List<RemovePenaltyBoxCsvRequest> entityRequests)
        {
            var contacts = await _contactFetcher.FetchContacts(entityRequests);

            return await UpdateWrongNumberStatus(contacts);
        }
        #endregion
    }
}
