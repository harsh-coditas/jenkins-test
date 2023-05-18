using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Response.User;

namespace ConnectAndSellSupport.Services.Automapper.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<TUser, UserDetails>();
        }
    }
}
