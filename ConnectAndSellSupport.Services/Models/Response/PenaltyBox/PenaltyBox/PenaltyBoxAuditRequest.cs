using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Models.Request.PenaltyBox
{
    public class PenaltyBoxAuditRequest
    {
        public int CompanyId { get; set; }
        public DateTime FromDate { get; set; }
        public int?[] ListIds { get; set; }


        public string StatusType { get; set; }

        public DateTime ToDate { get; set; }
        public int?[] UserIds { get; set; }
    }
}
