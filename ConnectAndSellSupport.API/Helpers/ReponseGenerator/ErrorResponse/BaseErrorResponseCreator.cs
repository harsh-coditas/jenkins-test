using ResponseModel = ConnectAndSellSupport.API.Models.Response;
using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse
{
    public static class BaseErrorResponseCreator
    {
        #region Public methods
        public static ResponseModel.BaseErrorResponse GetBaseErrorResponse(List<string> errorCodes)
        {
            var errorResponseList = new List<ResponseModel.ErrorResponse>();
            foreach (var error in errorCodes)
            {
                errorResponseList.Add(new ResponseModel.ErrorResponse(error));
            }

            return new ResponseModel.BaseErrorResponse { Errors = errorResponseList };
        }
        #endregion
    }
}
