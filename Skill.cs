using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    public class Skill : AuditableEntity
    {
        public int SkillId { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
        // New: Navigation for job skill requirements
        public ICollection<JobSkillRequirement> JobSkillRequirements { get; set; } = new List<JobSkillRequirement>();
    }
}
