using ConnectAndSellSupport.Domain.Models.Custom.User;

namespace ConnectAndSellSupport.Services.Helpers
{
    public static class CasRoleProvider
    {

        public static bool IsInRole(this string permittedRole, params Roles[] roles)
        {
            if (string.IsNullOrWhiteSpace(permittedRole) || !int.TryParse(permittedRole, out int permittedRoleValue))
            {
                return false;
            }

            foreach (var role in roles)
            {
                var roleValue = (int)role;
                if ((permittedRoleValue & roleValue).Equals(roleValue))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsInRole(this int permittedRole, params Roles[] roles)
        {
            if (permittedRole == default)
            {
                return false;
            }

            foreach (var role in roles)
            {
                var roleValue = (int)role;
                if ((permittedRole & roleValue).Equals(roleValue))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
