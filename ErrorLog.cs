namespace JobMagnet.Domain.Entities
{
    public class ErrorLog : AuditableEntity
    {
        public int ErrorLogId { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string ErrorMessage { get; set; } = null!;
        public string StackTrace { get; set; } = null!;
        public string? RequestPath { get; set; }
    }
}
