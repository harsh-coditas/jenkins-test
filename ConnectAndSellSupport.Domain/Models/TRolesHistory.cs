using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TRolesHistory
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public byte Pitcher { get; set; }
        public byte Crmadministrator { get; set; }
        public byte WebManager { get; set; }
        public byte Coach { get; set; }
        public byte Demo { get; set; }
        public byte LeadPooling { get; set; }
        public byte Lightning { get; set; }
        public byte Dialer { get; set; }
        public byte Colv { get; set; }
        public byte ReportSuperUser { get; set; }
        public byte Ood { get; set; }
        public byte HotTransferTarget { get; set; }
        public byte Executive { get; set; }
        public byte SuperExecutive { get; set; }
        public byte Adminstrator { get; set; }
        public byte SessionManager { get; set; }
        public byte Agent { get; set; }
        public byte Resercher { get; set; }
        public byte SalesRep { get; set; }
        public byte Coordinator { get; set; }
        public byte ClientServiceMgr { get; set; }
        public byte Elm { get; set; }
        public byte NativeSfdc { get; set; }
        public byte FacilityManager { get; set; }
        public byte SessionAnalyst { get; set; }
        public byte Engineering { get; set; }
        public byte Status { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual TUser User { get; set; }
    }
}
