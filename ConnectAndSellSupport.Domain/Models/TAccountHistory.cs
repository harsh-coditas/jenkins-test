using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TAccountHistory
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string EntryType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public string Memo { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }

        public virtual TCompany Company { get; set; }
    }
}
