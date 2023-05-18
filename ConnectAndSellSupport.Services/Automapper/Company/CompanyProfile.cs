using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Response.Company;

namespace ConnectAndSellSupport.Services.Automapper.Company
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<TCompany, CompanyDetails>();
        }
    }
}
