﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCasListTeam
    {
        public int Id { get; set; }
        public int? ListId { get; set; }
        public int? TeamId { get; set; }
    }
}
