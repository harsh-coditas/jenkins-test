using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class SessionNote
    {
        public int NoteId { get; set; }
        public int SessionId { get; set; }
        public int NoteType { get; set; }
        public string NoteText { get; set; }
        public DateTime? DateModified { get; set; }
        public string Owner { get; set; }

        public virtual Typelkp NoteTypeNavigation { get; set; }
        public virtual Session Session { get; set; }
    }
}
