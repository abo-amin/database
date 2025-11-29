namespace JobMagnet.Domain.Entities
{
    public class Admin : AuditableEntity
    {
        public int AdminId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public byte AdminLevel { get; set; } = 1;
        public string? PermissionsJson { get; set; }
        public string? Notes { get; set; }
    }
}
