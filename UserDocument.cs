namespace JobMagnet.Domain.Entities
{
    public class UserDocument : AuditableEntity
    {
        public int UserDocumentId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string DocumentType { get; set; } = null!; // e.g., ID, Certificate, Resume
        public string FileUrl { get; set; } = null!;
        public bool IsVerified { get; set; } = false;
    }
}
