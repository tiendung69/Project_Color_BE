using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class PostproductionPlaning
    {
        public PostproductionPlaning()
        {
            Broadcastings = new HashSet<Broadcasting>();
            Movieapprovals = new HashSet<Movieapproval>();
            PostproductionProgresses = new HashSet<PostproductionProgress>();
        }

        public int Id { get; set; }
        public int? PreProductionId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? WorkContent { get; set; }
        public decimal? Budget { get; set; }
        public int? Status { get; set; }
        public DateTime? CloseDate { get; set; }
        public string? CloseReason { get; set; }
        public string? CloseNote { get; set; }

        public virtual PreproductionPlaning? PreProduction { get; set; }
        public virtual ICollection<Broadcasting> Broadcastings { get; set; }
        public virtual ICollection<Movieapproval> Movieapprovals { get; set; }
        public virtual ICollection<PostproductionProgress> PostproductionProgresses { get; set; }
    }
}
