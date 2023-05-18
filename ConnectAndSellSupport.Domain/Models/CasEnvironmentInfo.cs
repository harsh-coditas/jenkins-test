using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasEnvironmentInfo
    {
        public CasEnvironmentInfo()
        {
            CasUserEnvironmentMappers = new HashSet<CasUserEnvironmentMapper>();
        }

        public int EnvironmentId { get; set; }
        public string EnvironmentName { get; set; }
        public string EnvironmentLoginUrl { get; set; }

        public virtual ICollection<CasUserEnvironmentMapper> CasUserEnvironmentMappers { get; set; }
    }
}
