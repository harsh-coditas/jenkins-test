using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TContact
    {
        public TContact()
        {
            TContactPhoneNumbers = new HashSet<TContactPhoneNumber>();
            TPhoneCalls = new HashSet<TPhoneCall>();
        }

        public int Id { get; set; }
        public string HashKey { get; set; }
        public DateTime? LastKnownValid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public int? AverageCallLengthSeconds { get; set; }
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

        public virtual ICollection<TContactPhoneNumber> TContactPhoneNumbers { get; set; }
        public virtual ICollection<TPhoneCall> TPhoneCalls { get; set; }
    }
}
