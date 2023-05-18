using AutoMapper;
using ConnectAndSellSupport.Repository.Contracts.TCompany;
using ConnectAndSellSupport.Services.Contracts.Company;
using ConnectAndSellSupport.Services.Models.Response.Company;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Company
{
    public class CompanyFetcher : ICompanyFetcher
    {
        #region Private members
        private readonly ITCompanyRepository _tCompanyRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CompanyFetcher(
            ITCompanyRepository tCompanyRepository,
            IMapper mapper)
        {
            _tCompanyRepository = tCompanyRepository;
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public async Task<CompanyServiceResponse> GetCompanies()
        {
            var companies = await _tCompanyRepository.GetAll();

            if (!companies?.Any() ?? true)
            {
                return new CompanyServiceResponse
                {
                    CompaniesNotFound = true
                };
            }

            return new CompanyServiceResponse
            {
                Companies = _mapper.Map<List<CompanyDetails>>(companies),
                Success = true
            };
        }
        #endregion
    }
}
