using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;

namespace ConnectAndSellSupport.API.Validations.Filters
{
    public class PayLoadValidationFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errorsInModelState = context.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(
                        kvp => kvp.Key, 
                        kvp => kvp.Value.Errors.Select(x => x.ErrorMessage));

                var errorResponse = new List<ErrorResponse>();
                foreach (var modelError in errorsInModelState)
                {
                    foreach (var subError in modelError.Value)
                    {
                        var error = new ErrorResponse(subError);
                        errorResponse.Add(error);
                    }
                }

                var response = new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status400BadRequest,
                    Messages.ErrorMessage,
                    new BaseErrorResponse { Errors = errorResponse });

                context.Result = new BadRequestObjectResult(response);

                return;
            }

        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
