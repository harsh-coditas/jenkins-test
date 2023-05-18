using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TSpecialInstruction
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string SpecialInstructions { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string ModUser { get; set; }
        public string CompanyName { get; set; }
        public bool? IsOverrideSpecialInstruction { get; set; }

        public virtual TCompany Company { get; set; }
    }
}
