using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasConversationRatingOriginal
    {
        public int NoteId { get; set; }
        public string CategoryName { get; set; }
        public int? Rating { get; set; }
        public string RatedBy { get; set; }
        public string RateNote { get; set; }
        public string RateNoteBy { get; set; }
    }
}
