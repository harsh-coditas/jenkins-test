using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class SConnectsSummary
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public int SessionType { get; set; }
        public int Week { get; set; }
        public int DayOfWeek { get; set; }
        public int DayOfYear { get; set; }
        public int Connects { get; set; }
    }
}
