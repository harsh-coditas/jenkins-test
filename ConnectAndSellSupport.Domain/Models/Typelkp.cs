using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class Typelkp
    {
        public Typelkp()
        {
            SessionNotes = new HashSet<SessionNote>();
        }

        public int TypeId { get; set; }
        public string TypeGrp { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<SessionNote> SessionNotes { get; set; }
    }
}
