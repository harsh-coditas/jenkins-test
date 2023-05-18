using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using ConnectAndSellSupport.Services.Extensions;

namespace ConnectAndSellSupport.Services.Models.Request.PenaltyBox
{
    public class RemovePenaltyBoxCsvRequest
    {
        private string _entityType;

        public int ContactId { get; set; }       
        public string PhoneNumber { get; set; }
        public string EntityType
        {
            get
            {
                return _entityType;
            }
            set
            {
                _entityType = value;
                Type = _entityType.GetValueFromDescription<PenaltyBoxEntityType>();
            }
        }
        public PenaltyBoxEntityType Type { get; internal set; }
    }
}
