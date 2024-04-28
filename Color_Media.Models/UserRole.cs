using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }

        public virtual Commoncategory? Role { get; set; }
        public virtual User? User { get; set; }
    }
}
