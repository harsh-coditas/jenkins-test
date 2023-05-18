using AutoMapper;
using ConnectAndSellSupport.Domain.Models.Custom.Call;
using ConnectAndSellSupport.Repository.Contracts.CasCompanyDisposition;
using ConnectAndSellSupport.Repository.Contracts.CasNote;
using ConnectAndSellSupport.Repository.Contracts.TCall;
using ConnectAndSellSupport.Services.Contracts.Call;
using ConnectAndSellSupport.Services.Models.Response.Call;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Call
{
    public class CallRecordFetcher : ICallRecordFetcher
    {
        #region Private members
        private readonly ITCallRepository _tcallRepository;
        private readonly ICasNoteRepository _casNoteRepository;
        private readonly ICasCompanyDispositionRepository _casCompanyDispositionRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CallRecordFetcher(
            ITCallRepository tCallRepository,
            ICasNoteRepository casNoteRepository,
            ICasCompanyDispositionRepository casCompanyDispositionRepository,
            IMapper mapper)
        {
            _tcallRepository = tCallRepository;
            _casNoteRepository = casNoteRepository;
            _casCompanyDispositionRepository = casCompanyDispositionRepository;
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public async Task<CallRecordServiceResponse> GetAgentCallRecord(int leadTransitId)
        {
            var response = new CallRecordServiceResponse
            {
                CallType = CallType.Agent
            };

            var (agentRecord, pitcherRecord) = await _tcallRepository.GetCallByLeadTransitId(leadTransitId);

            if (agentRecord == default)
            {
                response.InvalidLeadTransitId = true;
                return response;
            }

            response.CallDetails = _mapper.Map<CallDetailsResponse>(agentRecord);
            response.Success = true;
            return response;
        }

        public async Task<CallRecordServiceResponse> GetPitcherCallRecord(int leadTransitId)
        {
            var response = new CallRecordServiceResponse
            {
                CallType = CallType.Pitcher
            };

            var (agentCallRecord, pitcherCallRecord) = await _tcallRepository.GetCallByLeadTransitId(leadTransitId);

            var casNote = await _casNoteRepository.GetByLeadTransitId(leadTransitId);

            if (pitcherCallRecord == default)
            {
                if (casNote == default)
                {
                    if (agentCallRecord == default)
                    {
                        response.InvalidLeadTransitId = true;
                        return response;
                    }

                    response.PitcherRecordNotFound = true;
                    response.CasNoteNotFound = true;
                    return response;
                }

                response.PitcherRecordNotFound = true;
                response.CallDetails = _mapper.Map<CallDetailsResponse>(casNote);

                var disposition = await _casCompanyDispositionRepository.GetByText(casNote.Disposition);
                response.CallDetails.DispositionId = disposition?.CompanyDispositionId;
            }
            else if (casNote == default)
            {
                response.CasNoteNotFound = true;
            }

            response.CallDetails ??= _mapper.Map<CallDetailsResponse>(pitcherCallRecord);
            response.NoteDetails = _mapper.Map<NoteDetailsResponse>(casNote);
            response.Success = true;
            return response;
        }
        #endregion
    }
}