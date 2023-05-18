﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class OutcomeAttemptDatum
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public string CampaignName { get; set; }
        public int? CampaignUserId { get; set; }
        public int? CallListId { get; set; }
        public DateTime? SessionDate { get; set; }
        public string Text { get; set; }
        public int? DispositionCount { get; set; }
        public byte? SessionType { get; set; }
        public bool? IsBadNumber { get; set; }
        public bool? DeletedUser { get; set; }
        public bool? DeletedList { get; set; }
        public int? MaxCallId { get; set; }
    }
}
