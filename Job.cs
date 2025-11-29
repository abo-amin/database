using System.Collections.Generic;
using System;

namespace JobMagnet.Domain.Entities
{
    public class Job : AuditableEntity
    {
        public int JobId { get; set; }
        public int PostedByUserId { get; set; }
        public User PostedByUser { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Location { get; set; } // Can be kept for general text location if Address is too specific
        
        // Modified: Replaced string Type with JobCategory and JobType
        public int JobCategoryId { get; set; }
        public JobCategory Category { get; set; } = null!;
        public int JobTypeId { get; set; }
        public JobType Type { get; set; } = null!;

        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();
        // New: Navigation for job skill requirements
        public ICollection<JobSkillRequirement> SkillRequirements { get; set; } = new List<JobSkillRequirement>();
    }
}
