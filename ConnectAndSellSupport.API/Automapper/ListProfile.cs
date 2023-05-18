using AutoMapper;
using ConnectAndSellSupport.API.Models.Response.List;
using ConnectAndSellSupport.Services.Models.Response.List;

namespace ConnectAndSellSupport.API.Automapper
{
    public class ListProfile : Profile
    {
        public ListProfile()
        {
            CreateMap<ListDetails, ListResponse>();
        }
    }
}
