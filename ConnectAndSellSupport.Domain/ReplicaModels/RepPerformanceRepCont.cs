using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class RepPerformanceRepCont
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
        public int? CallListId { get; set; }
        public string UserName { get; set; }
        public string ListName { get; set; }
        public string Text { get; set; }
        public byte? SessionType { get; set; }
        public int? MeetingSet { get; set; }
        public int? Meeting { get; set; }
        public int? Attempt { get; set; }
        public int? Connect { get; set; }
        public int? Conversation { get; set; }
        public int? FollowUp { get; set; }
        public int? PitcherTalkTime { get; set; }
        public int? PitcherLeadTime { get; set; }
        public bool? CallSentiment { get; set; }
        public bool? DeletedList { get; set; }
        public bool? DeletedUser { get; set; }
    }
}
