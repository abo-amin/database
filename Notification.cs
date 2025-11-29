namespace JobMagnet.Domain.Entities
{
    public class Notification : AuditableEntity
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string Type { get; set; } = null!; // e.g., JobApplied, MessageReceived, PaymentReceived
        public string Content { get; set; } = null!;
        public string? TargetUrl { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
