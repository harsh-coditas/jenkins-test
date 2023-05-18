using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCategoryAndRating
    {
        public int CompanyId { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Category4 { get; set; }
        public string Category5 { get; set; }
        public string Category6 { get; set; }
        public string Category7 { get; set; }
        public string Category1Desc { get; set; }
        public string Category2Desc { get; set; }
        public string Category3Desc { get; set; }
        public string Category4Desc { get; set; }
        public string Category5Desc { get; set; }
        public string Category6Desc { get; set; }
        public string Category7Desc { get; set; }
        public bool? IncludeNotes { get; set; }
        public bool? IncludeConclusion { get; set; }
        public string Score1Desc { get; set; }
        public string Score2Desc { get; set; }
        public string Score3Desc { get; set; }
        public string Score4Desc { get; set; }
        public string Score5Desc { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
