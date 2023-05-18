using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class DeletedUserDatum
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
