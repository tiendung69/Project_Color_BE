using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Estimate
    {
        public int Id { get; set; }
        public int? PreProductPlaningId { get; set; }
        public string? TaskName { get; set; }
        public string? Description { get; set; }
        public decimal? TimeEstimate { get; set; }
        public decimal? HumanResourceEstimate { get; set; }
        public decimal? OtherResourceEstimate { get; set; }
        public int? Phase { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual PreproductionPlaning? PreProductPlaning { get; set; }
    }
}
