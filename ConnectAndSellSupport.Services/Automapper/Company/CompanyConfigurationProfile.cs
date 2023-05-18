using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Response.Company;

namespace ConnectAndSellSupport.Services.Automapper.Company
{
    public class CompanyConfigurationProfile : Profile
    {
        public CompanyConfigurationProfile()
        {
            CreateMap<CasCompanyDisposition, CompanyDisposition>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CompanyDispositionId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.DispositionText))
                .ForMember(dest => dest.SortOrder, opt => opt.MapFrom(src => src.SortOrder ?? 0))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.DispositionType))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.DispositionMode))
                .ForMember(dest => dest.IsConversion, opt => opt.MapFrom(src => src.CountAsConversion));
        }
    }
}
