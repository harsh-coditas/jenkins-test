using AutoMapper;
using ConnectAndSellSupport.Repository.Contracts.CasCompanyDisposition;
using ConnectAndSellSupport.Services.Contracts.Company;
using ConnectAndSellSupport.Services.Models.Response.Company;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Company
{
    public class CompanyConfigurationFetcher : ICompanyConfigurationFetcher
    {
        #region Private members
        private readonly ICasCompanyDispositionRepository _casCompanyDispositionRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CompanyConfigurationFetcher(
            ICasCompanyDispositionRepository casCompanyDispositionRepository,
            IMapper mapper)
        {
            _casCompanyDispositionRepository = casCompanyDispositionRepository;
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public async Task<CompanyDispositionServiceResponse> GetCompanyDispositions(int companyId)
        {
            var dispositions = await _casCompanyDispositionRepository.GetByCompanyId(companyId);

            if (!dispositions?.Any() ?? true)
            {
                return new CompanyDispositionServiceResponse
                {
                    DispositionsNotFound = true,
                    Success = false
                };
            }

            return new CompanyDispositionServiceResponse
            {
                CompanyDispositions = _mapper.Map<List<CompanyDisposition>>(dispositions),
                Success = true
            };
        }
        #endregion
    }
}
