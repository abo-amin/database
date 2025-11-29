using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class FreelancerLevel
    {
        [Key]\n        public int LevelId { get; set; }
        [Required]\n        public string LevelName { get; set; }
        
        public decimal? MinRating { get; set; }
        
        public int? MinCompletedProjects { get; set; }
        
        public string? Description { get; set; }
    }


}
