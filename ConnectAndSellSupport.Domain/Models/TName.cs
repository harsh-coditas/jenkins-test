using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TName
    {
        public int Id { get; set; }
        public string CampaignIdentifier { get; set; }
        public string ParentType { get; set; }
        public string Text { get; set; }
        public string NameType { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public int CampaignId { get; set; }
        public int SessionId { get; set; }

        public virtual TCampaign Campaign { get; set; }
    }
}
