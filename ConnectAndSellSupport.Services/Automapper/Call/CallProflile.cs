using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Domain.Models.Custom.Company;
using ConnectAndSellSupport.Services.Models.Request.Call;
using ConnectAndSellSupport.Services.Models.Response.Call;
using System;

namespace ConnectAndSellSupport.Services.Automapper.Call
{
    public class CallProflile : Profile
    {
        public CallProflile()
        {
            CreateMap<TCall, CallDetailsResponse>();

            CreateMap<CasNote, CallDetailsResponse>(MemberList.Source);

            CreateMap<Domain.ReplicaModels.CasNote, CallDetailsResponse>(MemberList.Source);
                
            CreateMap<CasNote, NoteDetailsResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.NoteId));
                
            CreateMap<Domain.ReplicaModels.CasNote, NoteDetailsResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.NoteId));

            CreateMap<CallDetailsRequest, TCall>(MemberList.Source)
                .ForMember(dest => dest.TalkTimeInMilliseconds, opt => opt.MapFrom(src => src.TalkTime * 1000))
                .ForMember(dest => dest.EndTime,
                    opt => opt.MapFrom((src, dest) =>
                        {
                            return src.TalkTime.HasValue
                              ? dest.ThrowTime.Value.AddSeconds(src.TalkTime.Value)
                              : dest.EndTime;
                        }));

            CreateMap<CallDetailsRequest, Domain.ReplicaModels.TCall>(MemberList.Source)
                .ForMember(dest => dest.TalkTimeInMilliseconds, opt => opt.MapFrom(src => src.TalkTime * 1000))
                .ForMember(dest => dest.EndTime,
                    opt => opt.MapFrom((src, dest) =>
                        {
                            return src.TalkTime.HasValue
                              ? dest.ThrowTime.Value.AddSeconds(src.TalkTime.Value)
                              : dest.EndTime;
                        }));

            CreateMap<CasCompanyDisposition, TCall>(MemberList.Source)
                .ForMember(dest => dest.DispositionId, opt => opt.MapFrom(src => src.CompanyDispositionId))
                .ForMember(dest => dest.IsMeetingSet, opt => opt.MapFrom(src => src.CountAsConversion))
                .ForMember(dest => dest.IsFollowUpMarked, opt => opt.MapFrom(src => src.IsFollowUpMandatory))
                .ForMember(dest => dest.DispositionType,
                    opt => opt.MapFrom((src, dest) =>
                    {
                        _ = Enum.TryParse(src.DispositionType, out DispositionType result);
                        return result;
                    }));

            CreateMap<CasCompanyDisposition, Domain.ReplicaModels.TCall>(MemberList.Source)
                .ForMember(dest => dest.DispositionId, opt => opt.MapFrom(src => src.CompanyDispositionId))
                .ForMember(dest => dest.IsMeetingSet, opt => opt.MapFrom(src => src.CountAsConversion))
                .ForMember(dest => dest.IsFollowUpMarked, opt => opt.MapFrom(src => src.IsFollowUpMandatory))
                .ForMember(dest => dest.DispositionType,
                    opt => opt.MapFrom((src, dest) =>
                    {
                        _ = Enum.TryParse(src.DispositionType, out DispositionType result);
                        return result;
                    }));

            CreateMap<NoteDetailsRequest, CasNote>(MemberList.Source)
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.NoteText))
                .ForMember(dest => dest.NextCallDate, opt => opt.MapFrom(src => src.NextCallDate));

            CreateMap<NoteDetailsRequest, Domain.ReplicaModels.CasNote>(MemberList.Source)
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.NoteText))
                .ForMember(dest => dest.NextCallDate, opt => opt.MapFrom(src => src.NextCallDate));

            CreateMap<CasCompanyDisposition, CasNote>(MemberList.Source)
                .ForMember(dest => dest.Disposition, opt => opt.MapFrom(src => src.DispositionText));

            CreateMap<CasCompanyDisposition, Domain.ReplicaModels.CasNote>(MemberList.Source)
                .ForMember(dest => dest.Disposition, opt => opt.MapFrom(src => src.DispositionText));
        }
    }
}
