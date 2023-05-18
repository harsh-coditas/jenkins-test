using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TQueryTerm
    {
        public int Id { get; set; }
        public int QueryId { get; set; }
        public string ColumnName { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual TQuery Query { get; set; }
    }
}
