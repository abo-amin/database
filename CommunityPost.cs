using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    public class CommunityPost : AuditableEntity
    {
        public int CommunityPostId { get; set; }
        public int PostedByUserId { get; set; }
        public User PostedByUser { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string? Tags { get; set; }
        public int ViewCount { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<CommunityReply> Replies { get; set; } = new List<CommunityReply>();
    }
}
