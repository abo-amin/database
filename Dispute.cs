using System;

namespace JobMagnet.Domain.Entities
{
    public class Dispute : AuditableEntity
    {
        public int DisputeId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public int RaisedByUserId { get; set; }
        public User RaisedByUser { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public string? Details { get; set; }
        public string Status { get; set; } = "Open"; // e.g., Open, UnderReview, Resolved, Closed
        public DateTimeOffset ResolvedAt { get; set; }
        public string? ResolutionDetails { get; set; }
    }
}
