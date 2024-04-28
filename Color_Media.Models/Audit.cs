using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Audit
    {
        public int Id { get; set; }
        public DateTime? ProcessedAt { get; set; }
        public int? Type { get; set; }
        public string? UserName { get; set; }
        public string? EntityName { get; set; }
        public int? EntityId { get; set; }
        public string? AuditData { get; set; }
        public string? Action { get; set; }
    }
}
