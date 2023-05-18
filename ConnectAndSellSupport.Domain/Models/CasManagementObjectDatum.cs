using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasManagementObjectDatum
    {
        public int ManagementReportId { get; set; }
        public string OwnerId { get; set; }
        public bool? IsDeleted { get; set; }
        public string OrderName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedById { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? SystemModstamp { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string RelatedOpportunityName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FirstUsageDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public double? UnitsPurchased { get; set; }
        public double? DaysLapsed { get; set; }
        public double? BalanceDays { get; set; }
        public double? UnitsUsed { get; set; }
        public double? BalanceUnits { get; set; }
        public double? AnticipatedDaystoConsumeUnits { get; set; }
        public string ManagementReportName { get; set; }
        public string MrreportingId { get; set; }
        public DateTime? AnticipatedBalanceUnitCompletionDate { get; set; }
        public string Product { get; set; }
        public string Mrnotes { get; set; }
        public string SendMr { get; set; }
    }
}
