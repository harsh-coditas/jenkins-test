using AutoMapper;
using ConnectAndSellSupport.API.Models.Response.Company;
using ServiceModels = ConnectAndSellSupport.Services.Models.Response.Company;

namespace ConnectAndSellSupport.API.Automapper
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<ServiceModels.CompanyDisposition, CompanyDispositionResponse>();

            CreateMap<ServiceModels.CompanyDetails, CompanyResponse>();
        }
    }
}
