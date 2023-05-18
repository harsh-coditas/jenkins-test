using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response
{
    public class BaseErrorResponse
    {
        public bool Error = true;
        public List<ErrorResponse> Errors { get; set; }
    }

    public class ErrorResponse
    {
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        [JsonPropertyName("error_description")]
        public string ErrorDescription { get; set; }

        public ErrorResponse(string errorMessage)
        {
            string errorDescription = ErrorDescriptionCreator.GetDescription(errorMessage);

            if (!string.IsNullOrEmpty(errorDescription))
            {
                this.ErrorCode = errorMessage;
                this.ErrorDescription = errorDescription;
            }
            else if (!string.IsNullOrEmpty(errorMessage))
            {
                this.ErrorCode = APIErrorCodes.ValidationFailed;
                this.ErrorDescription = errorMessage;
            }
        }
    }
}
