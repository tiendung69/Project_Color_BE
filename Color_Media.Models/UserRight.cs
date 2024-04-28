using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class UserRight
    {
        public int Id { get; set; }
        public int? RightId { get; set; }
        public int? UserId { get; set; }

        public virtual Commoncategory? Right { get; set; }
        public virtual User? User { get; set; }
    }
}
