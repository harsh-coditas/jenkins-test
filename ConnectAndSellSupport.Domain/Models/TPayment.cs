using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TPayment
    {
        public int Id { get; set; }
        public int ContractAppendixId { get; set; }
        public DateTime DueDate { get; set; }
        public decimal DueAmount { get; set; }
        public string Terms { get; set; }
        public DateTime ReceivedDate { get; set; }
        public decimal ReceivedAmount { get; set; }
        public string Memo { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }

        public virtual TContractAppendix ContractAppendix { get; set; }
    }
}
