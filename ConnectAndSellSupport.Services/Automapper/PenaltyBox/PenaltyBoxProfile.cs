using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;

namespace ConnectAndSellSupport.Services.Automapper.PenaltyBox
{
    public class PenaltyBoxProfile : Profile
    {
        public PenaltyBoxProfile()
        {
            CreateMap<TDnc, TDncArchive>();
            CreateMap<CasPenalizedPhoneNumber,CasPenaltyBoxAudit>();
            CreateMap<CasPenalizedPhoneNumber, CasPenalizedPhoneNumberDetailsResponse>();
            CreateMap<CasPenaltyBoxAudit, CasPenaltyBoxDetailsResponse>();
        }
    }
}
