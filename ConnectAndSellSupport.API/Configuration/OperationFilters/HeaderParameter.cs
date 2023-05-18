using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Configuration.OperationFilters
{
    public class HeaderParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            operation.Parameters ??= new List<OpenApiParameter>();            

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "envName",
                In = ParameterLocation.Header,
                Description = "database environment",
                Required = true
            });           
        }
    }
}
