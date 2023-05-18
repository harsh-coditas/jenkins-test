using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using ConnectAndSellSupport.Repository.Contracts.CasContact;
using ConnectAndSellSupport.Repository.Contracts.CasListContact;
using ConnectAndSellSupport.Repository.Contracts.TCompany;
using ConnectAndSellSupport.Repository.Contracts.TUser;
using ConnectAndSellSupport.Services.Constants;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval;
using ConnectAndSellSupport.Services.Extensions;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.PenaltyBox.EntityRemoval
{
    public class ContactFetcher : IContactFetcher
    {
        #region Private members
        private readonly ITCompanyRepository _tCompanyRepository;
        private readonly ITUserRepository _tUserRepository;
        private readonly ICasContactRepository _casContactRepository;
        private readonly ICasListContactRepository _casListContactRepository;
        #endregion

        #region Constructor
        public ContactFetcher(
            ITCompanyRepository tCompanyRepository,
            ITUserRepository tUserRepository,
            ICasContactRepository casContactRepository,
            ICasListContactRepository casListContactRepository)
        {
            _tCompanyRepository = tCompanyRepository;
            _tUserRepository = tUserRepository;
            _casContactRepository = casContactRepository;
            _casListContactRepository = casListContactRepository;
        }
        #endregion

        #region Private methods
        private Expression<Func<CasContact,bool>> GetAdditionalFilterExpression(RemovePenaltyBoxEntityRequest entityRequest)
        {
            Expression<Func<CasContact, bool>> expression = entityRequest.Type switch
            {
                PenaltyBoxEntityType.MalformedNumber => 
                    (c) =>
                        c.LastModifiedDate.HasValue
                        && c.LastModifiedDate.Value >= entityRequest.FromDate
                        && c.LastModifiedDate.Value <= entityRequest.ToDate.AddDays(1)
                        && c.ContactStatus.Equals(Constant.MalformedNumberStatus),
                PenaltyBoxEntityType.WrongNumber =>
                    (c) => 
                        c.WrongNumberPenaltyBoxEntryDate.HasValue
                        && c.WrongNumberPenaltyBoxEntryDate.Value >= entityRequest.FromDate
                        && c.WrongNumberPenaltyBoxEntryDate.Value <= entityRequest.ToDate.AddDays(1),
                _ => (c) => true,
            };

            return expression;
        }

        private async Task<IEnumerable<CasContact>> GetContactsFromUserIds(RemovePenaltyBoxEntityRequest entityRequest)
        {
            return await _casContactRepository.GetMultiAsync(
                    GetAdditionalFilterExpression(entityRequest)
                    .AndAlso(c => entityRequest.UserIds.Contains(c.UserId)));
        }

        private async Task<IEnumerable<CasContact>> GetContactsFromListIds(RemovePenaltyBoxEntityRequest entityRequest)
        {
            var listContacts = await _casListContactRepository.GetByListIds(entityRequest.ListIds);
            if (listContacts.IsNullOrEmpty())
            {
                return default;
            }

            var listContactIds = listContacts.Select(l => l.ContactId);
            return await _casContactRepository.GetMultiAsync(
                GetAdditionalFilterExpression(entityRequest)
                .AndAlso(c => listContactIds.Contains(c.ContactId)));
        }

        private async Task<IEnumerable<CasContact>> GetContactsFromCompanyId(RemovePenaltyBoxEntityRequest entityRequest)
        {
            var users = await _tUserRepository.GetByCompanyId(entityRequest.CompanyId);
            if (users.IsNullOrEmpty())
            {
                return default;
            }

            var userContactIds = users.Select(u => u.Id);
            return await _casContactRepository.GetMultiAsync(
                    GetAdditionalFilterExpression(entityRequest)
                    .AndAlso(c => userContactIds.Contains(c.UserId)));
        }
        #endregion

        #region Interface implementations
        public async Task<List<CasContact>> FetchContacts(RemovePenaltyBoxEntityRequest entityRequest)
        {
            if (!entityRequest.UserIds.IsNullOrEmpty())
            {
                var userContacts = await GetContactsFromUserIds(entityRequest);

                if (userContacts.IsNullOrEmpty())
                {
                    return default;
                }

                // Filter by userids only
                if (entityRequest.ListIds.IsNullOrEmpty())
                {
                    return userContacts.ToList();
                }

                // Filter by user and list
                var listContacts = await GetContactsFromListIds(entityRequest);

                return listContacts.IsNullOrEmpty() ? default : userContacts.Intersect(listContacts).ToList();
            }

            // Filter by list only
            if (!entityRequest.ListIds.IsNullOrEmpty())
            {
                var listContacts = await GetContactsFromListIds(entityRequest);

                return listContacts.IsNullOrEmpty() ? default : listContacts.ToList();
            }

            // Filter by company
            return (await GetContactsFromCompanyId(entityRequest))?.ToList();
        }

        public async Task<List<CasContact>> FetchContacts(List<RemovePenaltyBoxCsvRequest> entityRequests)
        {
            var contactIds = entityRequests?.Select(e => e.ContactId)?.ToHashSet();

            if (contactIds.IsNullOrEmpty())
            {
                return default;
            }

            return (await _casContactRepository.GetByContactIds(contactIds)).ToList();
        }
        #endregion
    }
}
