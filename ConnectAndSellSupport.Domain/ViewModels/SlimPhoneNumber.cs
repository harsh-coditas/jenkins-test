using System;

namespace ConnectAndSellSupport.Domain.Models
{
    public class SlimPhoneNumber
    {
        public string PhoneNumber { get; set; }
        public int Attempts { get; set; }
        public int Connects { get; set; }
        public bool IsDirect { get; set; }
        public bool IsBad { get; set; }
        public DateTime BadNumberCreateDate { get; set; }
        public bool? IsZeroTalkTimeCall { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
