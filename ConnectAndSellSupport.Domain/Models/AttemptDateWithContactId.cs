using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class AttemptDateWithContactId
    {
        public int? ContactId { get; set; }
        public DateTime? FirstAttemptDate { get; set; }
        public DateTime? LastAttemptDate { get; set; }
    }
}
