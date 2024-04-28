using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Video
    {
        public int Id { get; set; }
        public int? ObjectId { get; set; }
        public int? ObjectType { get; set; }
        public string? VideoName { get; set; }
        public string? VideoUrl { get; set; }
        public decimal? VideoLength { get; set; }
        public decimal? VideoSize { get; set; }
        public string? Note { get; set; }
    }
}
