using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Commoncategory
    {
        public Commoncategory()
        {
            Broadcastings = new HashSet<Broadcasting>();
            PreproductionSegmentCommunes = new HashSet<PreproductionSegment>();
            PreproductionSegmentDistricts = new HashSet<PreproductionSegment>();
            PreproductionSegmentProvinces = new HashSet<PreproductionSegment>();
            RoleRightRights = new HashSet<RoleRight>();
            RoleRightRoles = new HashSet<RoleRight>();
            UserRights = new HashSet<UserRight>();
            UserRoles = new HashSet<UserRole>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Type { get; set; }
        public string? Description { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<Broadcasting> Broadcastings { get; set; }
        public virtual ICollection<PreproductionSegment> PreproductionSegmentCommunes { get; set; }
        public virtual ICollection<PreproductionSegment> PreproductionSegmentDistricts { get; set; }
        public virtual ICollection<PreproductionSegment> PreproductionSegmentProvinces { get; set; }
        public virtual ICollection<RoleRight> RoleRightRights { get; set; }
        public virtual ICollection<RoleRight> RoleRightRoles { get; set; }
        public virtual ICollection<UserRight> UserRights { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
