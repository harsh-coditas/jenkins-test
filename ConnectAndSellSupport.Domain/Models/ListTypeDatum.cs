using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class ListTypeDatum
    {
        public int? ListId { get; set; }
        public string ListName { get; set; }
        public int? ListTypeName { get; set; }
        public int? ListTypeId { get; set; }
    }
}
