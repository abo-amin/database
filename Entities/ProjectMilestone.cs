using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class ProjectMilestone
    {
        [Key]\n        public int MilestoneId { get; set; }
        
        public int ProjectId { get; set; }
        [Required]\n        public string Title { get; set; }
        
        public string? Description { get; set; }
        
        public decimal Amount { get; set; }
        
        public DateTimeOffset? DueDate { get; set; }
        
        public string Status { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }

        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }

    }


}
