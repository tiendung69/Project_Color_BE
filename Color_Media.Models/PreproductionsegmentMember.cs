using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class PreproductionsegmentMember
    {
        public int Id { get; set; }
        public int? PreProductionSegmentId { get; set; }
        public int? UserId { get; set; }
        public string? Role { get; set; }
        public string? Description { get; set; }

        public virtual PreproductionSegment? PreProductionSegment { get; set; }
        public virtual User? User { get; set; }
    }
}
