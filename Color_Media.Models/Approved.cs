using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Approved
    {
        public int Id { get; set; }
        public int? ObjectId { get; set; }
        public DateTime? ProcessedAt { get; set; }
        public int? ProcessedBy { get; set; }
        public string? Comment { get; set; }
        public int? Result { get; set; }
        public int? ObjectType { get; set; }
    }
}
