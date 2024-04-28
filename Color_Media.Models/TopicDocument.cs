using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class TopicDocument
    {
        public int Id { get; set; }
        public int? TopicId { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public string? FileUrl { get; set; }

        public virtual Topic? Topic { get; set; }
    }
}
