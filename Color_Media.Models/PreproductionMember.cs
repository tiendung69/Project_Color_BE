using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class PreproductionMember
    {
        public int Id { get; set; }
        public int? PreProductionId { get; set; }
        public int? MemberId { get; set; }
        public string? Role { get; set; }
        public string? Description { get; set; }

        public virtual User? Member { get; set; }
        public virtual PreproductionPlaning? PreProduction { get; set; }
    }
}
