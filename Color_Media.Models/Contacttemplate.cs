using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Contacttemplate
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public byte[] FileData { get; set; } = null!;
        public int? FileType { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
