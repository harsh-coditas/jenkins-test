using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TContract
    {
        public TContract()
        {
            TContractAppendices = new HashSet<TContractAppendix>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime ContractDate { get; set; }
        public string ContractNumber { get; set; }
        public string Notes { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual ICollection<TContractAppendix> TContractAppendices { get; set; }
    }
}
