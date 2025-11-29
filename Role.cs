using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? Description { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
