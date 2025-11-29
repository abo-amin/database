using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    // New: Job Type Entity (e.g., Full-time, Part-time, Contract)
    public class JobType : AuditableEntity
    {
        public int JobTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
