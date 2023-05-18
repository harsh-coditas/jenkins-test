using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TDxAppointment
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public DateTime? RecurrenceStart { get; set; }
        public DateTime? RecurrenceEnd { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? AllDay { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? Label { get; set; }
        public string ResourceId { get; set; }
        public string ReminderInfo { get; set; }
        public string RecurrenceInfo { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string ListName { get; set; }
        public int? Count { get; set; }
        public bool? Active { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
    }
}
