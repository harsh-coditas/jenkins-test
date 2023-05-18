using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TContactPhoneNumber
    {
        public int Id { get; set; }
        public int PhoneNumberId { get; set; }
        public int ContactId { get; set; }
        public string Ivrpath { get; set; }
        public string AdditionalIvrpath { get; set; }
        public string IvrpathNote { get; set; }
        public bool IsIvrpathValidated { get; set; }
        public int IvrpathScore { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public double? IvrpathTime { get; set; }
        public double? IvrpathTimeStdDev { get; set; }
        public int? IvrpathCount { get; set; }
        public double? AdditionalIvrpathTime { get; set; }
        public double? AdditionalIvrpathTimeStdDev { get; set; }
        public int? AdditionalIvrpathCount { get; set; }
        public bool IsDirect { get; set; }
        public DateTime? IsDirectModifiedDate { get; set; }
        public DateTime? LastAutoAgentAttemptDate { get; set; }
        public DateTime? LastConnectDate { get; set; }
        public string DispositionText { get; set; }

        public virtual TContact Contact { get; set; }
        public virtual TPhoneNumber PhoneNumber { get; set; }
    }
}
