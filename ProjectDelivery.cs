using System;

namespace JobMagnet.Domain.Entities
{
    public class ProjectDelivery : AuditableEntity
    {
        public int ProjectDeliveryId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string FileUrl { get; set; } = null!;
        public DateTimeOffset DeliveredAt { get; set; } = DateTimeOffset.UtcNow;
        public string Status { get; set; } = "PendingReview"; // e.g., PendingReview, Accepted, Rejected
    }
}
