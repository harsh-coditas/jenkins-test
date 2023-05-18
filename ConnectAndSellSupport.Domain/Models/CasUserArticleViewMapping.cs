using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasUserArticleViewMapping
    {
        public long UserArticleViewMappingId { get; set; }
        public long? ArticleId { get; set; }
        public int? UserId { get; set; }
        public DateTime? ViewedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual CasZendeskArticle Article { get; set; }
        public virtual TUser User { get; set; }
    }
}
