namespace JobMagnet.Domain.Entities
{
    // New: Linking table for Job and Skill
    public class JobSkillRequirement : AuditableEntity
    {
        public int JobId { get; set; }
        public Job Job { get; set; } = null!;
        public int SkillId { get; set; }
        public Skill Skill { get; set; } = null!;
        public bool IsMandatory { get; set; } = true;
        public int? MinimumExperienceYears { get; set; }
    }
}
