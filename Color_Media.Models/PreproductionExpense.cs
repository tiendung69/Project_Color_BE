using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class PreproductionExpense
    {
        public int Id { get; set; }
        public int? PreProductionId { get; set; }
        public int? SegmentId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int? ExpenseType { get; set; }
        public decimal? Amount { get; set; }
        public string? Reason { get; set; }
        public string? Note { get; set; }

        public virtual PreproductionPlaning? PreProduction { get; set; }
        public virtual PreproductionSegment? Segment { get; set; }
    }
}
