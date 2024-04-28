using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class User
    {
        public User()
        {
            Estimates = new HashSet<Estimate>();
            MovieapprovalDetails = new HashSet<MovieapprovalDetail>();
            PostproductionprogressMembers = new HashSet<PostproductionprogressMember>();
            PreproductionMembers = new HashSet<PreproductionMember>();
            PreproductionPlanings = new HashSet<PreproductionPlaning>();
            PreproductionprogressMembers = new HashSet<PreproductionprogressMember>();
            PreproductionsegmentMembers = new HashSet<PreproductionsegmentMember>();
            TeamMembers = new HashSet<TeamMember>();
            Teams = new HashSet<Team>();
            TopicMembers = new HashSet<TopicMember>();
            UserRights = new HashSet<UserRight>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? PassWord { get; set; }
        public string? Tel { get; set; }
        public int? DepartId { get; set; }
        /// <summary>
        /// 1-Active; -1 -Delete
        /// </summary>
        public int? Status { get; set; }

        public virtual Commoncategory? Depart { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<MovieapprovalDetail> MovieapprovalDetails { get; set; }
        public virtual ICollection<PostproductionprogressMember> PostproductionprogressMembers { get; set; }
        public virtual ICollection<PreproductionMember> PreproductionMembers { get; set; }
        public virtual ICollection<PreproductionPlaning> PreproductionPlanings { get; set; }
        public virtual ICollection<PreproductionprogressMember> PreproductionprogressMembers { get; set; }
        public virtual ICollection<PreproductionsegmentMember> PreproductionsegmentMembers { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<TopicMember> TopicMembers { get; set; }
        public virtual ICollection<UserRight> UserRights { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
