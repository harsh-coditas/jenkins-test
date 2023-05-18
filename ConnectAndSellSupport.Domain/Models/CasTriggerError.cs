using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerError
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? ErrorDate { get; set; }
    }
}
