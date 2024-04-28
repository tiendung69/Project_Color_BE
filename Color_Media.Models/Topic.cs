using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Topic
    {
        public Topic()
        {
            PreproductionPlanings = new HashSet<PreproductionPlaning>();
            TopicDocuments = new HashSet<TopicDocument>();
            TopicMembers = new HashSet<TopicMember>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Scenario { get; set; }
        public DateTime? EstimatedBegin { get; set; }
        public DateTime? EstimatedEnd { get; set; }
        public DateTime? EstimatedBroadcasting { get; set; }
        public decimal? EstimatedBudget { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int? Status { get; set; }
        public int? Type { get; set; }
        public int? ParentId { get; set; }
        public decimal? EstimatedCost { get; set; }

        public virtual ICollection<PreproductionPlaning> PreproductionPlanings { get; set; }
        public virtual ICollection<TopicDocument> TopicDocuments { get; set; }
        public virtual ICollection<TopicMember> TopicMembers { get; set; }
    }
}
