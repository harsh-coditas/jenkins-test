using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TLeadHistory
    {
        public int Xid { get; set; }
        public int Id { get; set; }
        public string Identifier { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ClientName { get; set; }
        public string CampaignName { get; set; }
        public string ListName { get; set; }
        public string SessionName { get; set; }
        public DateTime? TransitStamp { get; set; }
        public string CompanyName { get; set; }
        public string CompanyUrl { get; set; }
        public string CompanyTel1 { get; set; }
        public string CompanyExt1 { get; set; }
        public string CompanyTel2 { get; set; }
        public string CompanyExt2 { get; set; }
        public string CompanyAddr1 { get; set; }
        public string CompanyAddr2 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyZip { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyInfo { get; set; }
        public string ContactSalutation { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactJobTitle { get; set; }
        public string ContactDept { get; set; }
        public string ContactTel1 { get; set; }
        public string ContactExt1 { get; set; }
        public string ContactTel2 { get; set; }
        public string ContactExt2 { get; set; }
        public string ContactAddr1 { get; set; }
        public string ContactAddr2 { get; set; }
        public string ContactCity { get; set; }
        public string ContactState { get; set; }
        public string ContactZip { get; set; }
        public string ContactCountry { get; set; }
        public string TimeZone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactBackground { get; set; }
        public int? PrimaryNumberIndex { get; set; }
        public string ResearcherName { get; set; }
        public int? AgentCalls { get; set; }
        public string AgentName { get; set; }
        public string AgentComment { get; set; }
        public string AgentDisposition { get; set; }
        public int? AgentAction { get; set; }
        public DateTime? AgentDispositionStamp { get; set; }
        public int? PitcherCalls { get; set; }
        public string PitcherName { get; set; }
        public string PitcherComment { get; set; }
        public string PitcherDisposition { get; set; }
        public int? PitcherAction { get; set; }
        public DateTime? PitcherDispositionStamp { get; set; }
        public string ScriptName { get; set; }
        public bool IsDirectCall { get; set; }
        public DateTime? WaitDate { get; set; }
        public string DescA { get; set; }
        public string DescB { get; set; }
        public string DescC { get; set; }
        public string DescD { get; set; }
        public string DescE { get; set; }
        public string DescF { get; set; }
        public string DescG { get; set; }
        public string DescH { get; set; }
        public string DescI { get; set; }
        public string DescJ { get; set; }
        public string OwnerIdentifier { get; set; }
        public bool? Active { get; set; }
        public byte[] RowVersion { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public bool? IsDeleted { get; set; }
        public int TransitStatus { get; set; }
        public DateTime? ResearcherDate { get; set; }
        public string UniqueIdentifier { get; set; }
        public string InactiveReason { get; set; }
        public string LeadSource { get; set; }
        public string CrmId { get; set; }
        public string LastPitcherNote { get; set; }
        public string PitcherNotes { get; set; }
        public bool? DncOverride { get; set; }
        public string Referrer { get; set; }
        public string CallerId { get; set; }
        public bool CanLeaveVoicemail { get; set; }
        public int NumVoicemails { get; set; }
        public DateTime? LastVoicemail { get; set; }
        public string CrmUrlFormat { get; set; }
        public int CallingPriority { get; set; }
        public int MaxSessionCalls { get; set; }
        public int CallDelay { get; set; }
        public int SessionCalls { get; set; }
        public string AgentNotes { get; set; }
        public int? CompanyEmployees { get; set; }
        public int? CompanyRevenue { get; set; }
        public int SessionId { get; set; }
        public int? ContactId { get; set; }
        public int? CallListId { get; set; }
        public bool IsBlindLead { get; set; }
        public bool IsSuspectedDirectCall { get; set; }
        public string VoicemailFileName { get; set; }
        public bool IsAttempted { get; set; }
        public bool IsGracefulExit { get; set; }
        public string ReasonText { get; set; }
        public string InvalidDirectNumbers { get; set; }
        public int AttemptsCount { get; set; }
    }
}
