using AutoMapper;
using ConnectAndSellSupport.API.Models.Payload.Call;
using ConnectAndSellSupport.API.Models.Response.Call;
using ConnectAndSellSupport.Services.Models.Request.Call;
using ConnectAndSellSupport.Services.Models.Response.Call;
using System;

namespace ConnectAndSellSupport.API.Automapper
{
    public class CallProfile : Profile
    {
        public CallProfile()
        {
            CreateMap<CallDetailsResponse, AgentCallRecordResponse>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreateDate.Date));

            CreateMap<CallRecordServiceResponse, PitcherConversionRecordResponse>(MemberList.None)
                .ForMember(dest => dest.PitcherRecordFound, opt => opt.MapFrom(src => !src.PitcherRecordNotFound))
                .ForMember(dest => dest.NoteRecordFound, opt => opt.MapFrom(src => !src.CasNoteNotFound));

            CreateMap<CallDetailsResponse, PitcherConversionRecordResponse>(MemberList.Source)
                .ForMember(dest => dest.TalktimeInSeconds, opt => opt.MapFrom(src => src.TalkTime ?? 0));

            CreateMap<NoteDetailsResponse, PitcherConversionRecordResponse>(MemberList.Source)
                .ForMember(dest => dest.NoteText, opt => opt.MapFrom(src => src.Text));

            CreateMap<CallDetailsResponse, PitcherConversionUpdateRecordResponse>(MemberList.Source)
                .ForMember(dest => dest.TalktimeInSeconds, opt => opt.MapFrom(src => src.TalkTime ?? 0));

            CreateMap<NoteDetailsResponse, PitcherConversionUpdateRecordResponse>(MemberList.Source)
                .ForMember(dest => dest.NoteText, opt => opt.MapFrom(src => src.Text));

            CreateMap<AddCallRecordPayload, CallDetailsRequest>()
                .ForMember(dest => dest.TalkTime, opt => opt.MapFrom(src => src.TalktimeInSeconds));

            CreateMap<AddCallRecordPayload, NoteDetailsRequest>()
                .ForMember(dest => dest.TalkTime, opt => opt.MapFrom(src => src.TalktimeInSeconds));

            CreateMap<UpdateCallRecordPayload, CallDetailsRequest>()
                .ForMember(dest => dest.TalkTime, opt => opt.MapFrom(src => src.TalktimeInSeconds));

            CreateMap<UpdateCallRecordPayload, NoteDetailsRequest>()
                .ForMember(dest => dest.TalkTime, opt => opt.MapFrom(src => src.TalktimeInSeconds));
        }
    }
}
