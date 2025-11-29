using System;

namespace JobMagnet.Domain.Entities
{
    public class UserRole : AuditableEntity
    {
        // composite PK: UserId + RoleId
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
        public DateTimeOffset AssignedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
