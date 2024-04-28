using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class PreproductionprogressMember
    {
        public int Id { get; set; }
        public int? PreProductionProgressId { get; set; }
        public int? UserId { get; set; }
        public string? Role { get; set; }
        public string? Comment { get; set; }
        public int? Status { get; set; }
        public decimal? PercentComplete { get; set; }

        public virtual PreproductionProgress? PreProductionProgress { get; set; }
        public virtual User? User { get; set; }
    }
}
