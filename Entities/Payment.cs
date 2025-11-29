using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Payment
    {
        [Key]\n        public int PaymentId { get; set; }
        
        public int UserId { get; set; }
        
        public decimal Amount { get; set; }
        
        public decimal FeeAmount { get; set; }
        
        public string Currency { get; set; }
        
        public string Status { get; set; }
        
        public string? TransactionId { get; set; }
        
        public string? PaymentProvider { get; set; }
        
        public string? GatewayResponse { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public DateTimeOffset? CompletedAt { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
