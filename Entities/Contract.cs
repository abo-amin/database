using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Contract
    {
        [Key]\n        public int ContractId { get; set; }
        
        public int ProjectId { get; set; }
        
        public int ClientUserId { get; set; }
        
        public int FreelancerUserId { get; set; }
        [Required]\n        public string Terms { get; set; }
        
        public DateTimeOffset? SignedDate { get; set; }
        
        public string? ContractFileUrl { get; set; }

        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }

        [ForeignKey("ClientUserId")]
        public User? User { get; set; }

        [ForeignKey("FreelancerUserId")]
        public User? User { get; set; }

    }


}
