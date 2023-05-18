using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Response.List;

namespace ConnectAndSellSupport.Services.Automapper.List
{
    public class ListProfile : Profile
    {
        public ListProfile()
        {
            CreateMap<CasList, ListDetails>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ListId));
        }
    }
}
