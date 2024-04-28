using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Mappingfield
    {
        public int Id { get; set; }
        public string? Table { get; set; }
        public string? OriginField { get; set; }
        public string? NewField { get; set; }
    }
}
