using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    public class FreelancerLevel : AuditableEntity
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; } = null!;
        public decimal? MinRating { get; set; }
        public int? MinCompletedProjects { get; set; }
        public string? Description { get; set; }

        public ICollection<Freelancer> Freelancers { get; set; } = new List<Freelancer>();
    }
}
