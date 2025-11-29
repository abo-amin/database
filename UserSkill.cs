using System;

namespace JobMagnet.Domain.Entities
{
    public class UserSkill : AuditableEntity
    {
        // composite PK: UserId + SkillId
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int SkillId { get; set; }
        public Skill Skill { get; set; } = null!;
        public int? ProvenYears { get; set; }
        public string? CertificateUrl { get; set; }
        public int? VerifiedBy { get; set; }
        public DateTimeOffset? VerifiedAt { get; set; }
    }
}
