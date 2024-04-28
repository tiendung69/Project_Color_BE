using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class PreproductionPlaning
    {
        public PreproductionPlaning()
        {
            Estimates = new HashSet<Estimate>();
            PostproductionPlanings = new HashSet<PostproductionPlaning>();
            PreproductionExpenses = new HashSet<PreproductionExpense>();
            PreproductionMembers = new HashSet<PreproductionMember>();
            PreproductionProgresses = new HashSet<PreproductionProgress>();
            PreproductionSegments = new HashSet<PreproductionSegment>();
        }

        public int Id { get; set; }
        public int? TopicId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public decimal? Budget { get; set; }
        public int? ApprovedMember { get; set; }
        public int? Status { get; set; }
        public DateTime? CloseDate { get; set; }
        public decimal? CloseExpense { get; set; }
        public string? CloseNote { get; set; }
        public string? CloseReason { get; set; }
        public int? TeamId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Scenario { get; set; }

        public virtual User? ApprovedMemberNavigation { get; set; }
        public virtual Team? Team { get; set; }
        public virtual Topic? Topic { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<PostproductionPlaning> PostproductionPlanings { get; set; }
        public virtual ICollection<PreproductionExpense> PreproductionExpenses { get; set; }
        public virtual ICollection<PreproductionMember> PreproductionMembers { get; set; }
        public virtual ICollection<PreproductionProgress> PreproductionProgresses { get; set; }
        public virtual ICollection<PreproductionSegment> PreproductionSegments { get; set; }
    }
}
