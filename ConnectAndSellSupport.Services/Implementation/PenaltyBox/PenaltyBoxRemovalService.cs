using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Domain.Models.Custom.Common;
using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using ConnectAndSellSupport.Repository.Contracts.CasContact;
using ConnectAndSellSupport.Repository.Contracts.CasListContact;
using ConnectAndSellSupport.Repository.Contracts.TCompany;
using ConnectAndSellSupport.Repository.Contracts.TUser;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval;
using ConnectAndSellSupport.Services.CsvMapper.PenaltyBox;
using ConnectAndSellSupport.Services.Extensions;
using ConnectAndSellSupport.Services.Helpers.Csv;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.PenaltyBox
{
    public class PenaltyBoxRemovalService : IPenaltyBoxRemovalService
    {
        #region Private members
        private readonly ITCompanyRepository _tCompanyRepository;
        private readonly ITUserRepository _tUserRepository;
        private readonly ICasContactRepository _casContactRepository;
        private readonly ICasListContactRepository _casListContactRepository;
        private readonly IContactFetcher _filterContactService;
        private readonly EntityRemovalServiceResolver _entityRemovalServiceResolver;
        #endregion

        #region Constructor
        public PenaltyBoxRemovalService(
            ITCompanyRepository tCompanyRepository,
            ITUserRepository tUserRepository,
            ICasContactRepository casContactRepository,
            ICasListContactRepository casListContactRepository,
            IContactFetcher filterContactService,
            EntityRemovalServiceResolver entityRemovalServiceResolver)
        {
            _tCompanyRepository = tCompanyRepository;
            _tUserRepository = tUserRepository;
            _casContactRepository = casContactRepository;
            _casListContactRepository = casListContactRepository;
            _filterContactService = filterContactService;
            _entityRemovalServiceResolver = entityRemovalServiceResolver;
        }
        #endregion

        #region Interface implementations
        public async Task<RemovePenaltyBoxEntityServiceResponse> RemovePenaltyBoxEntity(RemovePenaltyBoxEntityRequest entityRequest)
        {
            if (entityRequest.CompanyId == default)
            {
                return new RemovePenaltyBoxEntityServiceResponse { ContactsNotFound = true };
            }

            var entityRemovalService = _entityRemovalServiceResolver(entityRequest.Type);

            if (entityRemovalService == null)
            {
                throw new NotSupportedException("entity");
            }

            return await entityRemovalService.RemoveEntity(entityRequest);
        }

        public async Task<RemovePenaltyBoxEntityBulkServiceResponse> RemovePenaltyBoxEntity(int companyId, IFormFile entityRequest)
        {
            if (entityRequest == null || !Path.GetExtension(entityRequest.FileName).Equals(FileExtension.Csv.GetDescription()))
            {
                return new RemovePenaltyBoxEntityBulkServiceResponse { InvalidFileFormat = true };
            }

            var entities = CsvService.ReadCSVFile<RemovePenaltyBoxCsvRequest, PenaltyBoxRemovalMap>(entityRequest);

            if (companyId == default)
            {
                return new RemovePenaltyBoxEntityBulkServiceResponse { InvalidCompanyId = true };
            }

            if (entities.IsNullOrEmpty())
            {
                return new RemovePenaltyBoxEntityBulkServiceResponse { EmptyFile = true };
            }

            var filteredContacts = new List<CasContact>();

            var entityDictonary = new Dictionary<PenaltyBoxEntityType, List<RemovePenaltyBoxCsvRequest>>();

            entities.ForEach(c =>
            {
                if (c != default)
                {
                    if (!entityDictonary.ContainsKey(c.Type))
                    {
                        entityDictonary[c.Type] = new List<RemovePenaltyBoxCsvRequest>();
                    }

                    entityDictonary[c.Type].Add(c);
                }
            });

            var result = new Dictionary<PenaltyBoxEntityType, RemovePenaltyBoxEntityServiceResponse>();

            foreach (var entity in entityDictonary)
            {
                var entityRemovalService = _entityRemovalServiceResolver(entity.Key);

                if (entityRemovalService == null)
                {
                    throw new NotSupportedException("entity");
                }

                var entityResponse = await entityRemovalService.RemoveEntity(companyId, entity.Value);

                result.Add(entity.Key, entityResponse);
            }

            return new RemovePenaltyBoxEntityBulkServiceResponse
            {
                Success = true,
                EntityDetails = result
            };
        }
        #endregion
    }
}