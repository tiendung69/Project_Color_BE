using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Mappingtable
    {
        public int Id { get; set; }
        public string? OriginTable { get; set; }
        public string? NewTable { get; set; }
    }
}
