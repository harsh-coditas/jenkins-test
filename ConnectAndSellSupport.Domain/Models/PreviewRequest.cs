using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class PreviewRequest
    {
        public PreviewRequest()
        {
            PreviewRequestResults = new HashSet<PreviewRequestResult>();
        }

        public long RequestId { get; set; }
        public Guid RequestKey { get; set; }
        public int UserId { get; set; }
        public string PreviewRequestBody { get; set; }
        public DateTime PreviewRequestDate { get; set; }

        public virtual PreviewRequestKey PreviewRequestKey { get; set; }
        public virtual ICollection<PreviewRequestResult> PreviewRequestResults { get; set; }
    }
}
