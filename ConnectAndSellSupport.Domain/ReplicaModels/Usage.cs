﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class Usage
    {
        public int Id { get; set; }
        public int LeadId { get; set; }
        public int LeadTransitId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string CampaignName { get; set; }
        public int CampaignUserId { get; set; }
        public int CallListId { get; set; }
        public DateTime? ActualDate { get; set; }
        public DateTime ThrowTime { get; set; }
        public string DispositionText { get; set; }
        public byte SessionType { get; set; }
        public int CallType { get; set; }
        public int? Attempt { get; set; }
        public int? Connect { get; set; }
        public int? Meeting { get; set; }
        public int? BadNumbers { get; set; }
        public bool? DeletedUser { get; set; }
        public bool? DeletedList { get; set; }
        public byte AssignmentType { get; set; }
        public bool? IsFollowUp { get; set; }
        public int? CallId { get; set; }
    }
}
