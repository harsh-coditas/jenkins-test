using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPbtemp
    {
        public string Ienumbers { get; set; }
        public DateTime? WrongNumberPenaltyBoxEntryDate { get; set; }
        public int ContactId { get; set; }
        public int CompanyId { get; set; }
        public string ClientName { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string CrmObject { get; set; }
        public int ClientId { get; set; }
        public string ClientCompanyName { get; set; }
        public int CampaignUserId { get; set; }
        public string CampaignName { get; set; }
    }
}
