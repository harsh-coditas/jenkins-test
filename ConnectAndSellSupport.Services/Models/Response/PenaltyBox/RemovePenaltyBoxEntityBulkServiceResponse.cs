using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using System.Collections.Generic;

namespace ConnectAndSellSupport.Services.Models.Response.PenaltyBox
{
    public class RemovePenaltyBoxEntityBulkServiceResponse : BaseServiceResponse
    {
        public Dictionary<PenaltyBoxEntityType, RemovePenaltyBoxEntityServiceResponse> EntityDetails { get; set; }
        public bool InvalidCompanyId { get; set; }
        public bool EmptyFile{ get; set; }
        public bool InvalidFileFormat { get; set; }
    }
}
