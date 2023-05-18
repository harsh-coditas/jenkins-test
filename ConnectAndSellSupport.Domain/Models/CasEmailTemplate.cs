using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasEmailTemplate
    {
        public int EmailTemplateId { get; set; }
        public string EmailType { get; set; }
        public string Crm { get; set; }
        public string EmailText { get; set; }
    }
}
