using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Badge
    {
        [Key]\n        public int BadgeId { get; set; }
        [Required]\n        public string Name { get; set; }
        
        public string? Description { get; set; }
        
        public string? IconUrl { get; set; }
    }


}
