using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class VCommoncategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Type { get; set; }
        public string? Description { get; set; }
        public int? ParentId { get; set; }
        public string? ParentName { get; set; }
        public int? GrandId { get; set; }
        public string? Grand { get; set; }
    }
}
