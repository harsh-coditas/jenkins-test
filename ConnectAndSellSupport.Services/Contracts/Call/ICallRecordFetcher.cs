using ConnectAndSellSupport.Services.Models.Response.Call;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Call
{
    public interface ICallRecordFetcher
    {
        Task<CallRecordServiceResponse> GetAgentCallRecord(int leadTransitId);
        Task<CallRecordServiceResponse> GetPitcherCallRecord(int leadTransitId);
    }
}
