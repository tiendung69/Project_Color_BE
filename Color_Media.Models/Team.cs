﻿using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Team
    {
        public Team()
        {
            PreproductionPlanings = new HashSet<PreproductionPlaning>();
            TeamMembers = new HashSet<TeamMember>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? LeaderId { get; set; }

        public virtual User? Leader { get; set; }
        public virtual ICollection<PreproductionPlaning> PreproductionPlanings { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
    }
}
