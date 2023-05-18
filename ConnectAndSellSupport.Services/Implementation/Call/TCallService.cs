using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Domain.Models.Custom.Call;
using ConnectAndSellSupport.Domain.Models.Custom.User;
using ConnectAndSellSupport.Repository.Contracts.TCall;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.TCall;
using ConnectAndSellSupport.Services.Constants;
using ConnectAndSellSupport.Services.Contracts.Call;
using ConnectAndSellSupport.Services.Models.Request.Call;
using ConnectAndSellSupport.Services.Models.Response.Call;
using System;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Call
{
    public class TCallService : ITCallService
    {
        #region Private members
        private readonly ITCallRepository _tcallRepository;
        private readonly ITCallReplicaRepository _tCallReplicaRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public TCallService(
            ITCallRepository tCallRepository,
            ITCallReplicaRepository tCallReplicaRepository,
            IMapper mapper)
        {
            _tcallRepository = tCallRepository;
            _tCallReplicaRepository = tCallReplicaRepository;
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations     
        public async Task<CallDetailsResponse> AddRecord(
            CallDetailsRequest requestModel,
            TCall agentCallRecord,
            CasCompanyDisposition disposition)
        {
            var pitcherRecord = _mapper.Map<TCall>(agentCallRecord);

            _mapper.Map(requestModel, pitcherRecord);

            if(disposition != default)
            {
                _mapper.Map(disposition, pitcherRecord);
            }

            var callEndTime = requestModel.TalkTime.HasValue 
                ? agentCallRecord.CallSendTime?.AddSeconds(requestModel.TalkTime.Value)
                : default;

            // Manual updates
            pitcherRecord.Id = default;
            pitcherRecord.UserName = agentCallRecord.CampaignName;
            pitcherRecord.ThrowTime = agentCallRecord.CallSendTime;
            pitcherRecord.LeadCatchTime = agentCallRecord.CallSendTime;
            pitcherRecord.CallSendTime = Constant.TCallDefaultDateTime;
            pitcherRecord.EndTime = callEndTime;
            pitcherRecord.EngineCallSignalTime = agentCallRecord.CallSendTime;
            pitcherRecord.EngineCallConnectTime = agentCallRecord.CallSendTime;
            pitcherRecord.PhoneSysConnectTime = agentCallRecord.CallSendTime;

            pitcherRecord.PrimaryNumberIndex = 0; 
            
            pitcherRecord.NameCatchTime = agentCallRecord.CallSendTime;
            pitcherRecord.LeadSendTime = Constant.TCallDefaultDateTime;

            pitcherRecord.CreateDate = callEndTime ?? agentCallRecord.CreateDate;
            pitcherRecord.ModDate = callEndTime ?? agentCallRecord.CreateDate;

            pitcherRecord.UserRole = (int)Roles.Pitcher;
            pitcherRecord.PopupTime = agentCallRecord.CallSendTime;
            pitcherRecord.CachedLeadDisplayTime = agentCallRecord.CallSendTime;
            pitcherRecord.ActualLeadDisplayTime = Constant.TCallDefaultDateTime;

            pitcherRecord.IsValidConnect = true; 
            pitcherRecord.UserPostAction = (int)PostAction.Deactivate; 
            pitcherRecord.WaitTime = 0;
            pitcherRecord.IsColv = agentCallRecord.SessionType?.Equals(SessionType.COLV); 
            pitcherRecord.IsTransfer = 0; 

            pitcherRecord.CallType = (byte)CallType.Pitcher;

            pitcherRecord.ProblemCodes = 0;
            pitcherRecord.ProblemComments = string.Empty;


            await _tcallRepository.AddAsync(pitcherRecord);
            return _mapper.Map<CallDetailsResponse>(pitcherRecord);
        }

        public async Task AddRecordInReplicaDB(
            CallDetailsRequest requestModel,
            Domain.ReplicaModels.TCall agentCallRecord,
            CasCompanyDisposition disposition)
        {
            var pitcherRecord = _mapper.Map<Domain.ReplicaModels.TCall>(agentCallRecord);

            _mapper.Map(requestModel, pitcherRecord);

            if (disposition != default)
            {
                _mapper.Map(disposition, pitcherRecord);
            }

            var callEndTime = requestModel.TalkTime.HasValue
                ? agentCallRecord.CallSendTime?.AddSeconds(requestModel.TalkTime.Value)
                : default;

            // Manual updates
            pitcherRecord.Id = default;
            pitcherRecord.UserName = agentCallRecord.CampaignName;
            pitcherRecord.ThrowTime = agentCallRecord.CallSendTime;
            pitcherRecord.LeadCatchTime = agentCallRecord.CallSendTime;
            pitcherRecord.CallSendTime = Constant.TCallDefaultDateTime;
            pitcherRecord.EndTime = callEndTime;
            pitcherRecord.EngineCallSignalTime = agentCallRecord.CallSendTime;
            pitcherRecord.EngineCallConnectTime = agentCallRecord.CallSendTime;
            pitcherRecord.PhoneSysConnectTime = agentCallRecord.CallSendTime;

            pitcherRecord.PrimaryNumberIndex = 0;

            pitcherRecord.NameCatchTime = agentCallRecord.CallSendTime;
            pitcherRecord.LeadSendTime = Constant.TCallDefaultDateTime;

            pitcherRecord.CreateDate = callEndTime ?? agentCallRecord.CreateDate;
            pitcherRecord.ModDate = callEndTime ?? agentCallRecord.CreateDate;

            pitcherRecord.UserRole = (int)Roles.Pitcher;
            pitcherRecord.PopupTime = agentCallRecord.CallSendTime;
            pitcherRecord.CachedLeadDisplayTime = agentCallRecord.CallSendTime;
            pitcherRecord.ActualLeadDisplayTime = Constant.TCallDefaultDateTime;

            pitcherRecord.IsValidConnect = true;
            pitcherRecord.UserPostAction = (int)PostAction.Deactivate;
            pitcherRecord.WaitTime = 0;
            pitcherRecord.IsColv = agentCallRecord.SessionType?.Equals(SessionType.COLV);
            pitcherRecord.IsTransfer = 0;

            pitcherRecord.CallType = (byte)CallType.Pitcher;

            pitcherRecord.ProblemCodes = 0;
            pitcherRecord.ProblemComments = string.Empty;


            await _tCallReplicaRepository.AddAsync(pitcherRecord);
        }



        public async Task<CallDetailsResponse> UpdateRecord(
            CallDetailsRequest requestModel,
            TCall callRecord,
            CasCompanyDisposition disposition)
        {
            _mapper.Map(requestModel, callRecord);

            if (disposition != default)
            {
                _mapper.Map(disposition, callRecord);
            }
            callRecord.ProblemCodes = 0;
            callRecord.ProblemComments = string.Empty;
            await _tcallRepository.UpdateAsync(callRecord);

            return _mapper.Map<CallDetailsResponse>(callRecord);
        }

        public async Task UpdateRecordInReplicaDB(
            CallDetailsRequest requestModel,
            Domain.ReplicaModels.TCall callRecord,
            CasCompanyDisposition disposition)
        {
            try
            {
                _mapper.Map(requestModel, callRecord);
            }
            catch (Exception ex)
            {
            }

            if (disposition != default)
            {
                _mapper.Map(disposition, callRecord);
            }
            callRecord.ProblemCodes = 0;
            callRecord.ProblemComments = string.Empty;
            try
            {
                await _tCallReplicaRepository.UpdateAsync(callRecord);
            }
            catch (Exception ex)
            {
            }
        }

        #endregion
    }
}