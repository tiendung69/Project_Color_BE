using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Broadcastingdocument
    {
        public int Id { get; set; }
        public int BroadcastingId { get; set; }
        public string? FileName { get; set; }
        public string? FileType { get; set; }
        public string? FileUrl { get; set; }
        public string? Description { get; set; }

        public virtual Broadcasting Broadcasting { get; set; } = null!;
    }
}
