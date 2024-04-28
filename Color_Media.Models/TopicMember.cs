﻿using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class TopicMember
    {
        public int Id { get; set; }
        public int? TopicId { get; set; }
        public int? MemberId { get; set; }
        public string? Role { get; set; }
        public string? Description { get; set; }

        public virtual User? Member { get; set; }
        public virtual Topic? Topic { get; set; }
    }
}
