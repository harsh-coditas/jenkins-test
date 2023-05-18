using ConnectAndSellSupport.Services.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator
{
    public interface IResponseFactory
    {
        IActionResult GetResponse(BaseServiceResponse serviceResponse);
        IActionResult GetErrorResponse(int statusCode, params string[] errorCodes);
    }
}
