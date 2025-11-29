namespace JobMagnet.Domain.Entities
{
    public class SavedJob : AuditableEntity
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int JobId { get; set; }
        public Job Job { get; set; } = null!;
    }
}
