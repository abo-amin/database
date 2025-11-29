namespace JobMagnet.Domain.Entities
{
    public class Favorite : AuditableEntity
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string EntityType { get; set; } = null!; // e.g., Company, Post
        public int EntityId { get; set; }
    }
}
