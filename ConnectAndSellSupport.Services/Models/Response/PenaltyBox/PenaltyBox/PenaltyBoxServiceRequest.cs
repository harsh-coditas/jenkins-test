using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Models.Request.PenaltyBox
{
    public class PenaltyBoxServiceRequest
    {
        public PenalizedPhoneNumberRequest penalizedNumberDetails { get; set; }
        public PenaltyBoxAuditRequest penaltyBoxAuditDetails { get; set; }

    }
}
