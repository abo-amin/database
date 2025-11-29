using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class SavedFreelancer
    {
        [Key]\n        public int UserId { get; set; }
        [Key]\n        public int FreelancerUserId { get; set; }
        
        public DateTimeOffset SavedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("FreelancerUserId")]
        public User? User { get; set; }

    }


}
