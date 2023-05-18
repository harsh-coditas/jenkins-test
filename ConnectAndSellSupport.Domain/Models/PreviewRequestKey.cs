using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class PreviewRequestKey
    {
        public PreviewRequestKey()
        {
            PreviewRequests = new HashSet<PreviewRequest>();
        }

        public Guid RequestKey { get; set; }
        public int RequestUserId { get; set; }
        public DateTime RequestedDate { get; set; }

        public virtual ICollection<PreviewRequest> PreviewRequests { get; set; }
    }
}
