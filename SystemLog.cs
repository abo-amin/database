namespace JobMagnet.Domain.Entities
{
    public class SystemLog : AuditableEntity
    {
        public int SystemLogId { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string Level { get; set; } = null!; // e.g., Info, Warning, Error
        public string Message { get; set; } = null!;
        public string? StackTrace { get; set; }
    }
}
