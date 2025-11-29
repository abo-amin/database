using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Project
    {
        [Key]\n        public int ProjectId { get; set; }
        
        public int OwnerUserId { get; set; }
        
        public int? AssignedFreelancerId { get; set; }
        [Required]\n        public string Title { get; set; }
        [Required]\n        public string Description { get; set; }
        
        public decimal Budget { get; set; }
        
        public string Status { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("OwnerUserId")]
        public User? User { get; set; }

        [ForeignKey("AssignedFreelancerId")]
        public Freelancer? Freelancer { get; set; }

    }


}
