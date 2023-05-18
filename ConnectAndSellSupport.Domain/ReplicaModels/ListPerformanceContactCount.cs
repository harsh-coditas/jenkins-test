﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class ListPerformanceContactCount
    {
        public int Id { get; set; }
        public int? LeadtransitId { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public string CampaignName { get; set; }
        public int? CampaignUserId { get; set; }
        public int? CallListId { get; set; }
        public DateTime? ThrowTime { get; set; }
        public byte? SessionType { get; set; }
        public int? ContactId { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactCompanyName { get; set; }
        public string DispositionText { get; set; }
        public byte? CallType { get; set; }
        public int? Attempt { get; set; }
        public int? Connect { get; set; }
        public int? Conversation { get; set; }
        public int? Meetingset { get; set; }
        public bool? IsPbrecord { get; set; }
        public bool? DeletedUser { get; set; }
        public bool? DeletedList { get; set; }
        public int? CallId { get; set; }
    }
}
