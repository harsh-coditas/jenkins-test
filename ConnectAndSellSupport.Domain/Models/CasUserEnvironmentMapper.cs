using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasUserEnvironmentMapper
    {
        public int MapperId { get; set; }
        public int? EnvironmentId { get; set; }
        public int? EnvUserId { get; set; }
        public string EnvLoginId { get; set; }
        public string EnvLoginEmailId { get; set; }
        public int? EnvCompanyId { get; set; }
        public string EnvCompanyName { get; set; }
        public string EnvImageUrl { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserIdentifier { get; set; }
        public bool IsDeleted { get; set; }
        public int? PermittedRoles { get; set; }
        public bool IsSsoenabled { get; set; }

        public virtual CasEnvironmentInfo Environment { get; set; }
    }
}
