using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class EscrowTransaction
    {
        [Key]\n        public int EscrowTransactionId { get; set; }
        
        public int ProjectId { get; set; }
        
        public int FreelancerUserId { get; set; }
        
        public decimal Amount { get; set; }
        
        public decimal FeeAmount { get; set; }
        
        public string? Currency { get; set; }
        
        public string Status { get; set; }
        
        public string? PaymentProvider { get; set; }
        
        public string? GatewayResponse { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }

        [ForeignKey("FreelancerUserId")]
        public User? User { get; set; }

    }


}
