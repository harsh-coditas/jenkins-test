using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasCompanyDisposition;
using ConnectAndSellSupport.Repository.Contracts.CasNote;
using ConnectAndSellSupport.Repository.Contracts.TCall;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.CasNote;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.TCall;
using ConnectAndSellSupport.Services.Contracts.Call;
using ConnectAndSellSupport.Services.Models.Request.Call;
using ConnectAndSellSupport.Services.Models.Response.Call;
using System;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Call
{
    public class CallRecordUpdater : ICallRecordUpdater
    {
        #region Private members
        private readonly ITCallRepository _tcallRepository;
        private readonly ITCallReplicaRepository _tCallReplicaRepository;
        private readonly ICasNoteRepository _casNoteRepository;
        private readonly ICasNoteReplicaRepository _casNoteReplicaRepository;
        private readonly ICasCompanyDispositionRepository _casCompanyDispositionRepository;
        private readonly ITCallService _tCallService;
        private readonly ICasNoteService _casNoteService;
        #endregion

        #region Constructor
        public CallRecordUpdater(
            ITCallRepository tCallRepository,
            ICasNoteRepository casNoteRepository,
            ICasNoteReplicaRepository casNoteReplicaRepository,
            ICasCompanyDispositionRepository casCompanyDispositionRepository,
            ITCallService tCallService,
            ICasNoteService casNoteService,
            ITCallReplicaRepository tCallReplicaRepository)
        {
            _tcallRepository = tCallRepository;
            _casNoteRepository = casNoteRepository;
            _casNoteReplicaRepository = casNoteReplicaRepository;
            _casCompanyDispositionRepository = casCompanyDispositionRepository;
            _tCallService = tCallService;
            _casNoteService = casNoteService;
            _tCallReplicaRepository = tCallReplicaRepository;
        }
        #endregion

        #region Interface implementations
        public async Task<PitcherCallRecordUpdateServiceResponse> AddOrUpdatePitcherCallRecord(int leadTransitId, CallRecordServiceRequest requestModel)
        {
            (var agentRecord, var pitcherRecord) = await _tcallRepository.GetCallByLeadTransitId(leadTransitId);
            (var agentRecordReplica, var pitcherRecordReplica) = await _tCallReplicaRepository.GetCallByLeadTransitId(leadTransitId);

            if (agentRecord == default)
            {
                return new PitcherCallRecordUpdateServiceResponse
                {
                    InvalidLeadTransitId = true
                };
            }

            CasCompanyDisposition disposition = null;
            if (requestModel.CallDetails.DispositionId.HasValue)
            {
                disposition = await _casCompanyDispositionRepository.GetById(requestModel.CallDetails.DispositionId.Value);
                if (disposition == default || !disposition.CompanyId.Equals(agentRecord.ClientId))
                {
                    return new PitcherCallRecordUpdateServiceResponse
                    {
                        InvalidDispositionId = true
                    };
                }
            }

            if (requestModel.NoteDetails.NextCallDate.HasValue
                && requestModel.NoteDetails.NextCallDate.Value.Date < agentRecord.CreateDate.Date)
            {
                return new PitcherCallRecordUpdateServiceResponse
                {
                    InvalidNextCallDate = true
                };
            }

            var casNote = await _casNoteRepository.GetByLeadTransitId(leadTransitId);

            var note = (casNote == default)
                ? await _casNoteService.AddRecord(requestModel.NoteDetails, agentRecord, disposition)
                : await _casNoteService.UpdateRecord(requestModel.NoteDetails, casNote, disposition);

            var callRecord = (pitcherRecord == default)
                ? await _tCallService.AddRecord(requestModel.CallDetails, agentRecord, disposition)
                : await _tCallService.UpdateRecord(requestModel.CallDetails, pitcherRecord, disposition);

            //Update previous dates records only
            if (agentRecord.CreateDate.Date != DateTime.UtcNow.Date)
            {
                var casNoteReplica = await _casNoteReplicaRepository.GetByLeadTransitId(leadTransitId);
                if (pitcherRecord == default)
                    await _casNoteService.AddRecordInReplicaDB(requestModel.NoteDetails, agentRecordReplica, disposition);
                else
                    await _casNoteService.UpdateRecordInReplicaDB(requestModel.NoteDetails, casNoteReplica, disposition);


                if (pitcherRecord == default)
                    await _tCallService.AddRecordInReplicaDB(requestModel.CallDetails, agentRecordReplica, disposition);
                else
                    await _tCallService.UpdateRecordInReplicaDB(requestModel.CallDetails, pitcherRecordReplica, disposition);
            }

            return new PitcherCallRecordUpdateServiceResponse
            {
                CallDetails = callRecord,
                NoteDetails = note,
                Success = true
            };
        }
        #endregion
    }
}