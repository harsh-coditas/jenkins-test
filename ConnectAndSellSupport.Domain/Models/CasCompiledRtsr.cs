using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCompiledRtsr
    {
        public int CompiledRtsrid { get; set; }
        public string ProductType { get; set; }
        public string ClientName { get; set; }
        public string PitcherName { get; set; }
        public DateTime? SessionDate { get; set; }
        public byte? CalendarMonth { get; set; }
        public byte? CalendarWeek { get; set; }
        public byte? CalendarDay { get; set; }
        public string OrderNo { get; set; }
        public string ActualStartTime { get; set; }
        public string ActualEndTime { get; set; }
        public double? ActualHrs { get; set; }
        public double? PausedMins { get; set; }
        public double? TalkTime { get; set; }
        public double? WrapTime { get; set; }
        public double? WaitTime { get; set; }
        public double? SessionDialTime { get; set; }
        public double? AvgPauseTime { get; set; }
        public double? AvgTalkTime { get; set; }
        public double? AvgWrapTime { get; set; }
        public double? AvgWaitTime { get; set; }
        public string SessionType { get; set; }
        public int? ContactsStart { get; set; }
        public int? NumberOfDials { get; set; }
        public int? TotalConnects { get; set; }
        public int? ValidConnects { get; set; }
        public int? MeetingConnects { get; set; }
        public int? PositiveConnects { get; set; }
    }
}
