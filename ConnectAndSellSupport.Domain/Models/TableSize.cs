using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TableSize
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public int? RowSize { get; set; }
    }
}
