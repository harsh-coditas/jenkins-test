using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class TCompany
    {
        public int? Id { get; set; }
        public string Identifier { get; set; }
        public string CompanyName { get; set; }
        public int? Kind { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Tel1 { get; set; }
        public string Ext1 { get; set; }
        public string Tel2 { get; set; }
        public string Ext2 { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string Overview { get; set; }
        public int? Employees { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Growth { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public string Fax { get; set; }
        public string FaxExt { get; set; }
        public string CrmUrlFormat { get; set; }
        public string SalesRep { get; set; }
        public DateTime? SalesRepDate { get; set; }
        public string AccountMgr { get; set; }
        public DateTime? AccountMgrDate { get; set; }
        public string ClientSvcsMgr { get; set; }
        public DateTime? ClientSvcsMgrDate { get; set; }
        public string Memo { get; set; }
        public bool IsDispositionRequired { get; set; }
        public bool IsVoicemailEnabled { get; set; }
        public string TimeZone { get; set; }
        public int Priority { get; set; }
        public int Sla { get; set; }
        public string PreferredCrm { get; set; }
        public string CrmLoginMask { get; set; }
        public int? Colvpriority { get; set; }
        public int? Colvsla { get; set; }
        public string ScriptCompanyName { get; set; }
        public int? PermittedRoles { get; set; }
        public string SfaccountUrl { get; set; }
        public string SessionReportDl { get; set; }
        public string EngineIdentifier { get; set; }
        public string AccountId { get; set; }
        public bool? IsStatusActive { get; set; }
        public Guid? Rowguid { get; set; }
    }
}
