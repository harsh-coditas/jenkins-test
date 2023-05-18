using ConnectAndSellSupport.Services.Models.Response;
using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Models.Payload.Roles
{
    public class RoleData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class RoleDataResponse: BaseServiceResponse
    {
        public List<RoleData> roles { get; set; }
        public bool rolesNotFound { get; set; }
    }
}
