using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TAgentNote
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string AuthorName { get; set; }
        public string NoteText { get; set; }
        public string AgentDisposition { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModDate { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
