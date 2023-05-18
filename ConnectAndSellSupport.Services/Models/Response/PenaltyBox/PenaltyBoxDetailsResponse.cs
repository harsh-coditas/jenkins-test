using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Models.Response.PenaltyBox
{
    public class PenaltyBoxDetailsResponse : BaseServiceResponse
    {
        public List<CasPenalizedPhoneNumberDetailsResponse> CasPenalizedPhoneNumberDetails { get; set; }
        public List<CasPenaltyBoxDetailsResponse> CasPenaltyBoxDetails { get; set; }

        public bool CasPenaltyBoxNotFound { get; set; }

        public bool ContactNotFound { get; set; }
        public bool CasPenalizedPhoneNumberNotFound { get; set; }

    }
}
