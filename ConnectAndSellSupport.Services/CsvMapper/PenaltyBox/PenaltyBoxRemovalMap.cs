using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using CsvHelper.Configuration;

namespace ConnectAndSellSupport.Services.CsvMapper.PenaltyBox
{
    public class PenaltyBoxRemovalMap : ClassMap<RemovePenaltyBoxCsvRequest>
    {
        public PenaltyBoxRemovalMap()
        {
            Map(x => x.ContactId).Name("ContactId", "Contact Id");
            Map(x => x.PhoneNumber).Name("Phone", "Actual Penalized Number");   
            Map(x => x.EntityType).Name("Disposition", "EntityType", "Type");
            Map(x => x.Type).Ignore();
        }
    }
}