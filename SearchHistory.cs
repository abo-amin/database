using System;

namespace JobMagnet.Domain.Entities
{
    public class SearchHistory : AuditableEntity
    {
        public int SearchHistoryId { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string SearchQuery { get; set; } = null!;
        public string EntityType { get; set; } = null!; // e.g., Job, Freelancer, Post
        public DateTimeOffset SearchedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
