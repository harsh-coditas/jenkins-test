using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasConversationRating
    {
        public int Id { get; set; }
        public int? NoteId { get; set; }
        public int? Category1 { get; set; }
        public string RateNote1 { get; set; }
        public int? Category2 { get; set; }
        public string RateNote2 { get; set; }
        public int? Category3 { get; set; }
        public string RateNote3 { get; set; }
        public int? Category4 { get; set; }
        public string RateNote4 { get; set; }
        public int? Category5 { get; set; }
        public string RateNote5 { get; set; }
        public int? Category6 { get; set; }
        public string RateNote6 { get; set; }
        public int? Category7 { get; set; }
        public string RateNote7 { get; set; }
        public string Conclusion { get; set; }
        public string RatedBy { get; set; }
        public string RateNoteBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? CompanyId { get; set; }
    }
}
