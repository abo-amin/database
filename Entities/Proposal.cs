using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Proposal
    {
        [Key]\n        public int ProposalId { get; set; }
        
        public int ProjectId { get; set; }
        
        public int FreelancerUserId { get; set; }
        
        public decimal ProposedAmount { get; set; }
        
        public string? ProposalText { get; set; }
        
        public string Status { get; set; }
        
        public DateTimeOffset SentAt { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }

        [ForeignKey("FreelancerUserId")]
        public User? User { get; set; }

    }


}
