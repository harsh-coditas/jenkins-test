using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class AttemptDatum
    {
        public string Environment { get; set; }
        public string CampaignName { get; set; }
        public string UserCompanyName { get; set; }
        public int? LeadTransitId { get; set; }
        public string StartTime { get; set; }
        public string LeadTime { get; set; }
        public string TalkTime { get; set; }
        public string WrapTime { get; set; }
        public double? Redials { get; set; }
        public double? LeadNumber { get; set; }
        public string Disposition { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string JobTitle { get; set; }
        public string Telephone { get; set; }
        public string Telephone2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Notes { get; set; }
        public string CallAlert { get; set; }
        public double? GracefulExit { get; set; }
        public string ConnectOnHello { get; set; }
        public string LeaveVoiceMail { get; set; }
        public string AttemptedByAutoAgent { get; set; }
        public string DirectNumber { get; set; }
        public string LastDirect { get; set; }
        public string NumberType { get; set; }
        public string LastAttemptedByAutoAgentOn { get; set; }
        public string DialingTime { get; set; }
        public string PersonAnswered { get; set; }
        public string IvrAnswered { get; set; }
        public string FaxAnswered { get; set; }
        public string IvrSuccess { get; set; }
        public string IvrPathBox1Post { get; set; }
        public string IvrPathBox2Post { get; set; }
        public string IvrPathBox3Post { get; set; }
        public string IvrPathNotesPostBox3Post { get; set; }
        public string CallerId { get; set; }
        public string SpecialInstruction { get; set; }
        public int? ContactId { get; set; }
        public DateTime? FirstAttemptDate { get; set; }
        public DateTime? LastAttemptDate { get; set; }
    }
}
