namespace JobMagnet.Domain.Entities
{
    public class CommunityReply : AuditableEntity
    {
        public int CommunityReplyId { get; set; }
        public int PostId { get; set; }
        public CommunityPost Post { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool IsDeleted { get; set; } = false;
    }
}
