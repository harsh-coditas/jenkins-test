using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Request.Call;
using ConnectAndSellSupport.Services.Models.Response.Call;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Call
{
    public interface ICasNoteService
    {
        Task<NoteDetailsResponse> AddRecord(NoteDetailsRequest requestModel, TCall agentRecord, CasCompanyDisposition disposition);
        Task<NoteDetailsResponse> AddRecordInReplicaDB(NoteDetailsRequest requestModel, Domain.ReplicaModels.TCall agentRecord, CasCompanyDisposition disposition);
        Task<NoteDetailsResponse> UpdateRecord(NoteDetailsRequest requestModel, CasNote casNote, CasCompanyDisposition disposition);
        Task<NoteDetailsResponse> UpdateRecordInReplicaDB(NoteDetailsRequest requestModel, Domain.ReplicaModels.CasNote casNote, CasCompanyDisposition disposition);
    }
}
