using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class PreproductionSegment
    {
        public PreproductionSegment()
        {
            PreproductionExpenses = new HashSet<PreproductionExpense>();
            PreproductionProgresses = new HashSet<PreproductionProgress>();
            PreproductionsegmentMembers = new HashSet<PreproductionsegmentMember>();
        }

        public int Id { get; set; }
        public int? PreProductionId { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public int? CommuneId { get; set; }
        public string? Address { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? Budget { get; set; }
        public int? Status { get; set; }
        public string? Scenario { get; set; }

        public virtual Commoncategory? Commune { get; set; }
        public virtual Commoncategory? District { get; set; }
        public virtual PreproductionPlaning? PreProduction { get; set; }
        public virtual Commoncategory? Province { get; set; }
        public virtual ICollection<PreproductionExpense> PreproductionExpenses { get; set; }
        public virtual ICollection<PreproductionProgress> PreproductionProgresses { get; set; }
        public virtual ICollection<PreproductionsegmentMember> PreproductionsegmentMembers { get; set; }
    }
}
