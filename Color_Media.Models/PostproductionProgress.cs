using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class PostproductionProgress
    {
        public PostproductionProgress()
        {
            PostproductionprogressMembers = new HashSet<PostproductionprogressMember>();
        }

        public int Id { get; set; }
        public int? PostProductionId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? TotalProgress { get; set; }
        public decimal? Expense { get; set; }
        public string? Note { get; set; }
        public bool? IsFinished { get; set; }

        public virtual PostproductionPlaning? PostProduction { get; set; }
        public virtual ICollection<PostproductionprogressMember> PostproductionprogressMembers { get; set; }
    }
}
