using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Request.Call;
using ConnectAndSellSupport.Services.Models.Response.Call;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Call
{
    public interface ITCallService
    {
        Task<CallDetailsResponse> AddRecord(CallDetailsRequest requestModel, TCall agentCallRecord, CasCompanyDisposition disposition);
        Task AddRecordInReplicaDB(CallDetailsRequest requestModel, Domain.ReplicaModels.TCall agentCallRecord, CasCompanyDisposition disposition);
        Task<CallDetailsResponse> UpdateRecord(CallDetailsRequest requestModel, TCall callRecord, CasCompanyDisposition disposition);
        Task UpdateRecordInReplicaDB(CallDetailsRequest requestModel, Domain.ReplicaModels.TCall callRecord, CasCompanyDisposition disposition);
    }
}
