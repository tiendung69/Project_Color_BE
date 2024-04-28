using System;
using System.Collections.Generic;

namespace Color_Media.Models
{
    public partial class Broadcasting
    {
        public Broadcasting()
        {
            Broadcastingdocuments = new HashSet<Broadcastingdocument>();
        }

        public int Id { get; set; }
        public int PostProductionPlaningId { get; set; }
        public int? ChannelId { get; set; }
        public DateTime? BroadcastingTime { get; set; }
        public long? Duration { get; set; }
        public DateTime? SubmissionTime { get; set; }
        public string? Reciever { get; set; }

        public virtual Commoncategory? Channel { get; set; }
        public virtual PostproductionPlaning PostProductionPlaning { get; set; } = null!;
        public virtual ICollection<Broadcastingdocument> Broadcastingdocuments { get; set; }
    }
}
