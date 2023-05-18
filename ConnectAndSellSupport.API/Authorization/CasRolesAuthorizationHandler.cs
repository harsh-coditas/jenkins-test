using ConnectAndSellSupport.Services.Helpers;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.API.Authorization
{
    public class CasRolesAuthorizationHandler : AuthorizationHandler<CasRolesRequirement>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            CasRolesRequirement requirement)
        {
            if (context.User == null || !context.User.Identity.IsAuthenticated)
            {
                return Task.CompletedTask;
            }

            var roleValue = context.User.FindFirstValue(ClaimTypes.Role);
            if (string.IsNullOrWhiteSpace(roleValue))
            {
                return Task.CompletedTask;
            }

            if (roleValue.IsInRole(requirement.AuthorizedRoles.ToArray()))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
