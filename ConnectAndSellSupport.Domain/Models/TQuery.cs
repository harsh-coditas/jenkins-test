using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TQuery
    {
        public TQuery()
        {
            TQueryTerms = new HashSet<TQueryTerm>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<TQueryTerm> TQueryTerms { get; set; }
    }
}
