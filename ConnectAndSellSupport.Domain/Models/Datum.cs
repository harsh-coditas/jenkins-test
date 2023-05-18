using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class Datum
    {
        public string Client { get; set; }
        public int UserThread { get; set; }
        public Guid Id { get; set; }
        public string Server { get; set; }
        public int Data { get; set; }
        public int AccessCount { get; set; }
        public string Username { get; set; }
        public byte[] Document { get; set; }
        public string DocumentType { get; set; }
    }
}
