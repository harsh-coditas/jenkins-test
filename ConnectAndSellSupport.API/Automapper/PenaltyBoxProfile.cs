using AutoMapper;
using ConnectAndSellSupport.API.Models.Payload.PenaltyBox;
using ConnectAndSellSupport.API.Models.Response.PenaltyBox;
using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Automapper
{
    public class PenaltyBoxProfile : Profile
    {
        public PenaltyBoxProfile()
        {
            CreateMap<RemovePenaltyBoxEntityPayload, RemovePenaltyBoxEntityRequest>();
            CreateMap<RemovePenaltyBoxEntity, PenalizedPhoneNumberRequest>();
            CreateMap<RemovePenaltyBoxPhoneNumber, RemovePenaltyBoxbyPhoneNumberRequest>();
            CreateMap<RemovePenaltyBoxById, RemovePenaltyBoxByIDRequest>();
            CreateMap<RemovePenaltyBoxEntity, PenaltyBoxAuditRequest>();
            CreateMap<RemovePenaltyBoxEntityBulkServiceResponse, RemovePenaltyBoxBulkResponse>()
                .ForMember(dest => dest.Entities, opt => opt.MapFrom(src => src.EntityDetails));
            CreateMap<PenaltyBoxDetailsResponse, PenaltyBoxFetcherResponse>();
            CreateMap<CasPenalizedPhoneNumberDetailsResponse, CasPenalisedPhoneNumberResponse>();
            CreateMap<CasPenaltyBoxDetailsResponse, CasPenaltyBoxResponse>();
           // CreateMap<CasPenaltyBoxDetailsResponse, PenaltyBoxFetcherResponse>();


            CreateMap<KeyValuePair<PenaltyBoxEntityType, RemovePenaltyBoxEntityServiceResponse>, KeyValuePair<PenaltyBoxEntityType, RemovePenaltyBoxResponse>>();
            CreateMap<RemovePenaltyBoxEntityServiceResponse, RemovePenaltyBoxResponse>();
        }
    }
}
