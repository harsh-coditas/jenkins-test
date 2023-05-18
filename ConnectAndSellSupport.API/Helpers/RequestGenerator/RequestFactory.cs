using AutoMapper;
using ConnectAndSellSupport.API.Models.Payload;
using ConnectAndSellSupport.API.Models.Payload.Call;
using ConnectAndSellSupport.API.Models.Payload.Data;
using ConnectAndSellSupport.API.Models.Payload.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Request.Call;
using ConnectAndSellSupport.Services.Models.Request.Data;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;

namespace ConnectAndSellSupport.API.Helpers.RequestGenerator
{
    public class RequestFactory : IRequestFactory
    {
        #region Private Members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public RequestFactory(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public object GetRequest(BasePayload basePayload)
        {
            return basePayload switch
            {
                AddCallRecordPayload addCallRecordPayload =>
                    new CallRecordServiceRequest
                    {
                        CallDetails = _mapper.Map<CallDetailsRequest>(addCallRecordPayload),
                        NoteDetails = _mapper.Map<NoteDetailsRequest>(addCallRecordPayload)
                    },

                UpdateCallRecordPayload updateCallRecordPayload =>
                    new CallRecordServiceRequest
                    {
                        CallDetails = _mapper.Map<CallDetailsRequest>(updateCallRecordPayload),
                        NoteDetails = _mapper.Map<NoteDetailsRequest>(updateCallRecordPayload)
                    },

                //RemovePenaltyBoxEntityPayload removePenaltyBoxEntityPayload =>
                //    _mapper.Map<RemovePenaltyBoxEntityRequest>(removePenaltyBoxEntityPayload),
                RemovePenaltyBoxEntity removePenaltyBoxEntityPayload =>
                     new PenaltyBoxServiceRequest
                     {
                          
                         penalizedNumberDetails = _mapper.Map<PenalizedPhoneNumberRequest>(removePenaltyBoxEntityPayload),
                         penaltyBoxAuditDetails = _mapper.Map<PenaltyBoxAuditRequest>(removePenaltyBoxEntityPayload)
                     },
                RemovePenaltyBoxPhoneNumber  removePenaltyBoxPhoneNumber => _mapper.Map<RemovePenaltyBoxbyPhoneNumberRequest>(removePenaltyBoxPhoneNumber),
                    
                RemovePenaltyBoxById  removePenaltyBoxById => _mapper.Map<RemovePenaltyBoxByIDRequest>(removePenaltyBoxById),


                GetReplenishmentPayload getReplenishmentPayload =>
               _mapper.Map<GetReplenishmentRequest>(getReplenishmentPayload),

                _ => null,
            };
        }
        #endregion
    }
}
