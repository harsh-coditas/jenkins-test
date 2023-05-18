using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TNote
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string ParentIdentifier { get; set; }
        public string ParentType { get; set; }
        public string AuthorName { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Text { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
    }
}
