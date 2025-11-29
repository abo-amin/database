namespace JobMagnet.Domain.Entities
{
    public class SavedFreelancer : AuditableEntity
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int FreelancerUserId { get; set; }
        public User FreelancerUser { get; set; } = null!;
    }
}
