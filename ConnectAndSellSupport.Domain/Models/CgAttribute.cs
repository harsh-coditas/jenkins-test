using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CgAttribute
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string FieldName { get; set; }
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public string AttributeValue { get; set; }
    }
}
