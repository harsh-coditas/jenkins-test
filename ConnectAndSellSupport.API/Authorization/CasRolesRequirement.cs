using ConnectAndSellSupport.Domain.Models.Custom.User;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;

namespace ConnectAndSellSupport.API.Authorization
{
    public class CasRolesRequirement : IAuthorizationRequirement
    {
        public List<Roles> AuthorizedRoles { get; set; }

        public CasRolesRequirement(params Roles[] roles)
        {
            AuthorizedRoles = roles.ToList();
        }
    }
}
