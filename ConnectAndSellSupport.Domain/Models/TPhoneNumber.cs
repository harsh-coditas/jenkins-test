using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TPhoneNumber
    {
        public TPhoneNumber()
        {
            TContactPhoneNumbers = new HashSet<TContactPhoneNumber>();
            TPhoneCalls = new HashSet<TPhoneCall>();
        }

        public int Id { get; set; }
        public string NormalizedNumber { get; set; }
        public bool IsIvr { get; set; }
        public bool IsFax { get; set; }
        public bool IsValid { get; set; }
        public bool IsCellPhone { get; set; }
        public bool IsDirect { get; set; }
        public bool IsGroupNumber { get; set; }
        public string Ivrpath { get; set; }
        public bool IsIvrpathValidated { get; set; }
        public int? IvrpathScore { get; set; }
        public string CallerIdString { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string TimeZone { get; set; }
        public int NumberAttempted { get; set; }
        public int NumberAnswered { get; set; }
        public int NumberConnected { get; set; }
        public int NumberInvalidConnects { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public double? IvrpathTime { get; set; }
        public double? IvrpathTimeStdDev { get; set; }
        public int? IvrpathCount { get; set; }
        public bool? IsZeroTalkTimeCall { get; set; }
        public bool WasAnsweredByPerson { get; set; }

        public virtual ICollection<TContactPhoneNumber> TContactPhoneNumbers { get; set; }
        public virtual ICollection<TPhoneCall> TPhoneCalls { get; set; }
    }
}
