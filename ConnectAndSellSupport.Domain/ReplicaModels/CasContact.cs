using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class CasContact
    {
        public int? ContactId { get; set; }
        public int UserId { get; set; }
        public DateTime? LastCall { get; set; }
        public DateTime? NextCall { get; set; }
        public string NextSteps { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string TimeZone { get; set; }
        public string Email { get; set; }
        public string CrmUrl { get; set; }
        public short? Priority { get; set; }
        public string Status { get; set; }
        public int? ReferralId { get; set; }
        public string CrmId { get; set; }
        public string Custom { get; set; }
        public string CrmId2 { get; set; }
        public string CrmObject { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Country { get; set; }
        public string CrmId3 { get; set; }
        public bool Active { get; set; }
        public bool? Accepted { get; set; }
        public string EnrichedPhone { get; set; }
        public string EnrichmentStatus { get; set; }
        public string EnrichmentSource { get; set; }
        public DateTime? EnrichedTimestamp { get; set; }
        public string EnrichedEmail { get; set; }
        public string EnrichedPhoneType { get; set; }
        public string EnrichedCompany { get; set; }
        public string EnrichedTitle { get; set; }
        public int? CompanyRevenue { get; set; }
        public int? CompanyHeadcount { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyIndustry { get; set; }
        public string JobPostingTitle { get; set; }
        public string JobPostingDescription { get; set; }
        public string Ienumbers { get; set; }
        public string ContactStatus { get; set; }
        public string SubStatus { get; set; }
        public DateTime? LastConnectDate { get; set; }
        public string SecondarySubStatus { get; set; }
        public DateTime? AppointmentDateTime { get; set; }
        public bool? IsInjectedContact { get; set; }
        public bool? IsDualSidedConversation { get; set; }
        public string LeadSource { get; set; }
        public DateTime? PostInjectedContactTime { get; set; }
        public bool? IsPostInjectedContact { get; set; }
        public string State { get; set; }
        public string ContactCountry { get; set; }
        public string InvalidDirectNumbers { get; set; }
        public DateTime? LastInvalidDate { get; set; }
        public DateTime? LastVoicemail { get; set; }
        public DateTime? MarkedOnDate { get; set; }
        public string MostRecentCampaign { get; set; }
        public DateTime? WrongNumberPenaltyBoxEntryDate { get; set; }
        public string AccountCity { get; set; }
        public string AccountState { get; set; }
        public string CompanyUrl { get; set; }
        public string CallOnDays { get; set; }
        public bool FollowUpHappened { get; set; }
        public int FollowUpCounter { get; set; }
        public bool FollowUpSet { get; set; }
        public int ConversationCounter { get; set; }
        public string ReferralCustom { get; set; }
        public string StepNotes { get; set; }
        public string ContactNotes { get; set; }
        public string CrmtimeZone { get; set; }
        public double Score { get; set; }
        public int? MovedIntoFollowUpListFromListId { get; set; }
        public string OriginListName { get; set; }
        public string LinkedInUrl { get; set; }
        public string OpportunityId { get; set; }
        public int CurrentDialingIndex { get; set; }
        public int NextDialingIndex { get; set; }
        public int CompanyId { get; set; }
        public int IsConnected { get; set; }
        public string Phone3 { get; set; }
        public DateTime? InjectedDateTime { get; set; }
    }
}
