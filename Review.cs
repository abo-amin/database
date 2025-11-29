namespace JobMagnet.Domain.Entities
{
    public class Review : AuditableEntity
    {
        public int ReviewId { get; set; }
        public int ReviewerId { get; set; }
        public User Reviewer { get; set; } = null!;
        public int TargetUserId { get; set; }
        public User TargetUser { get; set; } = null!;
        public int RatingValue { get; set; } // 1 to 5
        public string? Comment { get; set; }
        public string EntityType { get; set; } = null!; // e.g., Project, Job
        public int EntityId { get; set; }
    }
}
