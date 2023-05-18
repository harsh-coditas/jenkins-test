using ConnectAndSellSupport.API.Authorization;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.API.Helpers.RequestGenerator;
using ConnectAndSellSupport.API.Models.Payload.Roles;
using ConnectAndSellSupport.Domain.Models.Custom.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.API.Controllers
{
    [Route(Routes.GenericControllerV1)]
    [ApiController]
    [Authorize(Policy = Policies.AdminAndEngineering)]
    public class RolesController : ControllerBase
    {
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<RolesController> _logger;

        public RolesController(IResponseFactory responseFactory, ILogger<RolesController> logger)
        {
            _responseFactory = responseFactory;
            _logger = logger;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route(Routes.Roles)]
        public IActionResult GetRoles()
        {
            try
            {
                var r = GetEnumList<Roles>();
                return Ok(r); ;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve roles");
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
            
        }

        private static List<RoleData> GetEnumList<T>()
        {
            T[] array = (T[])Enum.GetValues(typeof(T));
            List<RoleData> list = new List<RoleData>();
            foreach (var data in Enum.GetNames(typeof(T)))
            {
                RoleData role = new RoleData();
                role.Name = data;
                role.Id = (int)Enum.Parse(typeof(T), data);
                list.Add(role);
            }
            

            return list;
        }
    }
}
