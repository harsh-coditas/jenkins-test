using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TCrmParamSet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserIdentifier { get; set; }
        public string DataSourceName { get; set; }
        public string ParamA { get; set; }
        public string ParamB { get; set; }
        public string ParamC { get; set; }
        public string ParamD { get; set; }
        public string ParamE { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public string ParamF { get; set; }
    }
}
