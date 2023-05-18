using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TActivity
    {
        public int Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string UserName { get; set; }
        public string CampaignName { get; set; }
        public string Message { get; set; }
        public string Datum { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public int Type { get; set; }
        public int? SessionId { get; set; }
    }
}
