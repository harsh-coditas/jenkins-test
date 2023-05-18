using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasUserContactAolist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public string ActOnListId { get; set; }
        public string ContactActOnId { get; set; }
    }
}
