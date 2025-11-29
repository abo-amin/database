namespace JobMagnet.Domain.Entities
{
    public class ActivityLog : AuditableEntity
    {
        public int ActivityLogId { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string ActivityType { get; set; } = null!; // e.g., Login, JobPosted, ProfileUpdated
        public string Details { get; set; } = null!;
        public string? IpAddress { get; set; }
    }
}
