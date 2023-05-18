using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class DeletedListDatum
    {
        public int Id { get; set; }
        public int? ListId { get; set; }
        public bool? Isdeleted { get; set; }
        public byte? AssignmentType { get; set; }
        public bool? IsFollowUp { get; set; }
    }
}
