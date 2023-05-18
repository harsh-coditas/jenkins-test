using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.Services.Models.Response;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler
{
    public delegate IServiceResponseHandler ServiceReponseHandlerResolver(BaseServiceResponse serviceResponse);

    public interface IServiceResponseHandler
    {
        Response GetSucessResponse(BaseServiceResponse serviceResponse);
        Response GetErrorResponse(BaseServiceResponse serviceResponse);
    }
}
