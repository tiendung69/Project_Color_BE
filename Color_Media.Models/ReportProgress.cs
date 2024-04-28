using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class ReportProgress
    {
        public string? TopicName { get; set; }
        public DateTime? MinEstimatedBegin { get; set; }
        public DateTime? EstimatedEnd { get; set; }
        public int? Type { get; set; }
        public int? CreatedBy { get; set; }
        public int? TopicStatus { get; set; }
        public string? PreProductionPlanName { get; set; }
        public int? PreProductionPlanStatus { get; set; }
        public DateTime? PostProductionFromDate { get; set; }
        public int? PostProductionStatus { get; set; }
        public DateTime? PostProductionToDate { get; set; }
        public decimal? TotalProgress { get; set; }
    }
}
