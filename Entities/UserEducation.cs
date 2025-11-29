using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class UserEducation
    {
        [Key]\n        public int EducationId { get; set; }
        
        public int UserId { get; set; }
        [Required]\n        public string Degree { get; set; }
        [Required]\n        public string Institution { get; set; }
        
        public string? FieldOfStudy { get; set; }
        
        public DateTimeOffset? StartDate { get; set; }
        
        public DateTimeOffset? EndDate { get; set; }
        
        public string? Description { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
