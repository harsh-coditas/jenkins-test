using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCrmfilter23740
    {
        public int CrmfilterId { get; set; }
        public int ListId { get; set; }
        public string FieldName { get; set; }
        public int Operation { get; set; }
        public string Value { get; set; }
        public string SecondaryFilter { get; set; }
        public string ContactListname { get; set; }
        public string SecondaryFilterName { get; set; }
        public int? ExtendedGroupId { get; set; }
        public string ExtendedFiltersCondition { get; set; }
        public string ExtendedGroupsCondition { get; set; }
    }
}
