using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCallPreference
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ListId { get; set; }
        public int ContactId { get; set; }
        public DateTime LastModDate { get; set; }
        public bool? IsLeadPool { get; set; }
    }
}
