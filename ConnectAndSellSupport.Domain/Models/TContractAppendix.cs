using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TContractAppendix
    {
        public TContractAppendix()
        {
            TPayments = new HashSet<TPayment>();
        }

        public int Id { get; set; }
        public int ContractId { get; set; }
        public DateTime EngagementStart { get; set; }
        public DateTime EngagementEnd { get; set; }
        public string EngagementName { get; set; }
        public string ServiceType { get; set; }
        public int? Hours { get; set; }
        public decimal? RatePerHour { get; set; }
        public int? Connects { get; set; }
        public decimal? RatePerConnect { get; set; }
        public decimal ServicesTotal { get; set; }
        public decimal ProservTotal { get; set; }
        public decimal GrandTotal { get; set; }
        public int ConnectsPerHourSla { get; set; }
        public int WeeklyHours { get; set; }
        public string Memo { get; set; }
        public string RevenueRecognitionType { get; set; }
        public string RecurrenceType { get; set; }
        public int RecurrenceUnits { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }

        public virtual TContract Contract { get; set; }
        public virtual ICollection<TPayment> TPayments { get; set; }
    }
}
