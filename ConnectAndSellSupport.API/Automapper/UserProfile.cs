using AutoMapper;
using ConnectAndSellSupport.API.Models.Response.User;
using ConnectAndSellSupport.Services.Models.Response.User;

namespace ConnectAndSellSupport.API.Automapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<LoginServiceResponse, LoginResponse>();
            CreateMap<RefreshTokenServiceResponse, RefreshTokenResponse>();

            CreateMap<UserDetails, UserResponse>();
        }
    }
}
