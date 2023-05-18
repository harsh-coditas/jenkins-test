using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class MlTitle
    {
        public string Title { get; set; }
        public int? Count { get; set; }
        public string Role { get; set; }
        public string JobFunction { get; set; }
        public string TitleN { get; set; }
        public int Id { get; set; }
    }
}
