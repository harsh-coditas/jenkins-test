using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TPhoneCall
    {
        public int Id { get; set; }
        public DateTime? CallPlacedTime { get; set; }
        public DateTime? CallConnectedTime { get; set; }
        public DateTime? CallDisconnectedTime { get; set; }
        public DateTime? StartNavCompanyIvrtime { get; set; }
        public DateTime? StartNavDbnivrtime { get; set; }
        public bool WasAnsweredByPerson { get; set; }
        public bool WasAnsweredByIvr { get; set; }
        public bool DidProspectAnswer { get; set; }
        public string DialedNumber { get; set; }
        public string CallerId { get; set; }
        public int ContactId { get; set; }
        public int PhoneNumberId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public bool IsDialerSession { get; set; }
        public DateTime UserAttachTime { get; set; }
        public DateTime UserBridgeTime { get; set; }
        public int LeadTransitId { get; set; }
        public string Channel { get; set; }
        public DateTime? StartNavAdditionalDbnivrtime { get; set; }
        public int? ReportCodes { get; set; }
        public string ReportComments { get; set; }
        public int SessionId { get; set; }
        public bool AgentLockedOnConnect { get; set; }
        public string TerminationCode { get; set; }
        public bool IsAmd { get; set; }
        public string Amdresult { get; set; }
        public string Ivrpath { get; set; }
        public string PhoneNumberIvrpath { get; set; }
        public string AdditionalIvrpath { get; set; }
        public string IvrpathNote { get; set; }
        public bool IsFax { get; set; }
        public bool IsIvr { get; set; }
        public bool IsDirect { get; set; }
        public bool IsIvrpathValidated { get; set; }
        public bool AutoNavigateIvr { get; set; }

        public virtual TContact Contact { get; set; }
        public virtual TPhoneNumber PhoneNumber { get; set; }
    }
}
