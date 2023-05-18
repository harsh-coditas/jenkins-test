using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasZendeskArticle
    {
        public CasZendeskArticle()
        {
            CasUserArticleViewMappings = new HashSet<CasUserArticleViewMapping>();
        }

        public long ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleName { get; set; }
        public string ArticleSnippet { get; set; }
        public DateTime? ArticleCreatedDate { get; set; }
        public DateTime? ArticleUpdatedDate { get; set; }
        public long? SectionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<CasUserArticleViewMapping> CasUserArticleViewMappings { get; set; }
    }
}
