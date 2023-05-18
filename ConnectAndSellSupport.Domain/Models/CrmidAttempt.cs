using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CrmidAttempt
    {
        public string LeadId { get; set; }
        public string LeadStatus { get; set; }
        public string CompanyAccount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LastInitialName { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string DirectPhone { get; set; }
        public string Email { get; set; }
        public double? NumberofAttempts { get; set; }
    }
}
