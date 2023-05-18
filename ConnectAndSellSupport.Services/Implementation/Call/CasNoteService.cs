using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasList;
using ConnectAndSellSupport.Repository.Contracts.CasNote;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.CasList;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.CasNote;
using ConnectAndSellSupport.Services.Contracts.Call;
using ConnectAndSellSupport.Services.Models.Request.Call;
using ConnectAndSellSupport.Services.Models.Response.Call;
using System;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Call
{
    public class CasNoteService : ICasNoteService
    {
        #region Private members
        private readonly ICasNoteRepository _casNoteRepository;
        private readonly ICasNoteReplicaRepository _casNoteReplicaRepository;
        private readonly ICasListRepository _casListRepository;
        private readonly ICasListReplicaRepository _casListReplicaRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CasNoteService(
            ICasNoteRepository casNoteRepository,
            ICasNoteReplicaRepository casNoteReplicaRepository,
            ICasListRepository casListRepository,
            ICasListReplicaRepository casListReplicaRepository,
            IMapper mapper)
        {
            _casNoteRepository = casNoteRepository;
            _casNoteReplicaRepository = casNoteReplicaRepository;
            _casListRepository = casListRepository;
            _casListReplicaRepository = casListReplicaRepository;
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations 
        public async Task<NoteDetailsResponse> AddRecord(
            NoteDetailsRequest requestModel,
            TCall agentRecord,
            CasCompanyDisposition disposition)
        {
            var casNote = _mapper.Map<CasNote>(requestModel);

            var casList = agentRecord.CallListId.HasValue
                ? await _casListRepository.GetById(agentRecord.CallListId.Value)
                : default;

            var callEndTime = requestModel.TalkTime.HasValue
               ? agentRecord.CallSendTime?.AddSeconds(requestModel.TalkTime.Value)
               : default;

            casNote.ContactId = agentRecord.ContactId ?? default;
            casNote.CreateDate = callEndTime ?? agentRecord.CreateDate; 
            casNote.UpdateDate = callEndTime ?? agentRecord.CreateDate;

            casNote.WrapTime = 0; 

            casNote.LeadTransitId = agentRecord.LeadTransitId;
            casNote.ListId = agentRecord.CallListId;
            casNote.SessionType = agentRecord.SessionType;
            casNote.ListOwnerId = casList?.UserId;
            casNote.IsBlindLead = agentRecord.IsBlindLead;
            casNote.UserId = agentRecord.CampaignUserId;
            casNote.RecordCall = false;
            casNote.IsCheckedForReview = false;
            casNote.ReviewDescription = string.Empty;
            //casNote.ConversationCounter
            casNote.IsColv = agentRecord.IsColv;

            _mapper.Map(disposition, casNote);

            await _casNoteRepository.AddAsync(casNote);

            return _mapper.Map<NoteDetailsResponse>(casNote);
        }

        public async Task<NoteDetailsResponse> AddRecordInReplicaDB(NoteDetailsRequest requestModel, Domain.ReplicaModels.TCall agentRecord, CasCompanyDisposition disposition)
        {
            var casNote = _mapper.Map<Domain.ReplicaModels.CasNote>(requestModel);

            var casList = agentRecord.CallListId.HasValue
                ? await _casListReplicaRepository.GetById(agentRecord.CallListId.Value)
                : default;

            var callEndTime = requestModel.TalkTime.HasValue
               ? agentRecord.CallSendTime?.AddSeconds(requestModel.TalkTime.Value)
               : default;

            casNote.ContactId = agentRecord.ContactId ?? default;
            casNote.CreateDate = callEndTime ?? agentRecord.CreateDate;
            casNote.UpdateDate = callEndTime ?? agentRecord.CreateDate;

            casNote.WrapTime = 0;

            casNote.LeadTransitId = agentRecord.LeadTransitId;
            casNote.ListId = agentRecord.CallListId;
            casNote.SessionType = agentRecord.SessionType;
            casNote.ListOwnerId = casList?.UserId;
            casNote.IsBlindLead = agentRecord.IsBlindLead;
            casNote.UserId = agentRecord.CampaignUserId;
            casNote.RecordCall = false;
            casNote.IsCheckedForReview = false;
            casNote.ReviewDescription = string.Empty;
            //casNote.ConversationCounter
            casNote.IsColv = agentRecord.IsColv;

            _mapper.Map(disposition, casNote);

            await _casNoteReplicaRepository.AddAsync(casNote);

            return _mapper.Map<NoteDetailsResponse>(casNote);
        }

        public async Task<NoteDetailsResponse> UpdateRecord(
            NoteDetailsRequest requestModel,
            CasNote casNote,
            CasCompanyDisposition disposition)
        {
            _mapper.Map(requestModel, casNote);

            if (disposition != default)
            {
                _mapper.Map(disposition, casNote);
            }            

            await _casNoteRepository.UpdateAsync(casNote);

            return _mapper.Map<NoteDetailsResponse>(casNote);
        }

        public async Task<NoteDetailsResponse> UpdateRecordInReplicaDB(NoteDetailsRequest requestModel, Domain.ReplicaModels.CasNote casNote, CasCompanyDisposition disposition)
        {
            _mapper.Map(requestModel, casNote);

            if (disposition != default)
            {
                _mapper.Map(disposition, casNote);
            }

            await _casNoteReplicaRepository.UpdateAsync(casNote);

            return _mapper.Map<NoteDetailsResponse>(casNote);
        }
        #endregion
    }
}