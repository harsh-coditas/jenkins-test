﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMappingField1
    {
        public int MappingFieldId { get; set; }
        public int MappingId { get; set; }
        public string ContactFieldName { get; set; }
        public string CrmfieldName { get; set; }
        public bool Updateable { get; set; }
        public string CrmfieldType { get; set; }
        public bool? ValidateInCrm { get; set; }
        public bool Mandatory { get; set; }
    }
}
