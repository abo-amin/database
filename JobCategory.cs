using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    // New: Job Category Entity
    public class JobCategory : AuditableEntity
    {
        public int JobCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
