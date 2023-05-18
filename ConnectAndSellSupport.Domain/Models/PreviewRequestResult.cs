using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class PreviewRequestResult
    {
        public long ResultId { get; set; }
        public long RequestId { get; set; }
        public string ResultBody { get; set; }
        public DateTime ResultGenerationDate { get; set; }

        public virtual PreviewRequest Request { get; set; }
    }
}
