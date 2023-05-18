using ConnectAndSellSupport.Services.Models.Request.Call;
using ConnectAndSellSupport.Services.Models.Response.Call;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Call
{
    public interface ICallRecordUpdater
    {
        Task<PitcherCallRecordUpdateServiceResponse> AddOrUpdatePitcherCallRecord(int leadTransitId, CallRecordServiceRequest requestModel);
    }
}
