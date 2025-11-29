using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class UserWorkExperience
    {
        [Key]\n        public int WorkExperienceId { get; set; }
        
        public int UserId { get; set; }
        [Required]\n        public string JobTitle { get; set; }
        [Required]\n        public string Company { get; set; }
        
        public DateTimeOffset? StartDate { get; set; }
        
        public DateTimeOffset? EndDate { get; set; }
        
        public string? Description { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
