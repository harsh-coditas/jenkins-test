﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class CasNote
    {
        public int NoteId { get; set; }
        public int ContactId { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Disposition { get; set; }
        public string NextSteps { get; set; }
        public bool IsConversation { get; set; }
        public string Status { get; set; }
        public int? TalkTime { get; set; }
        public int? WrapTime { get; set; }
        public int? LeadTransitId { get; set; }
        public int? ListId { get; set; }
        public byte? SessionType { get; set; }
        public int? ListOwnerId { get; set; }
        public bool? IsBlindLead { get; set; }
        public int? UserId { get; set; }
        public bool? IsCheckedForReview { get; set; }
        public string ReviewDescription { get; set; }
        public DateTime? NextCallDate { get; set; }
        public bool FollowUpHappened { get; set; }
        public int FollowUpCounter { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public long? FollowUpDateInt { get; set; }
        public int ConversationCounter { get; set; }
        public bool? IsColv { get; set; }
        public string CallSentiment { get; set; }
        public bool? RecordCall { get; set; }
        public bool IsDualConsent { get; set; }
    }
}
