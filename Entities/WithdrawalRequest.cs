using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class WithdrawalRequest
    {
        [Key]\n        public int WithdrawalRequestId { get; set; }
        
        public int UserId { get; set; }
        
        public decimal Amount { get; set; }
        
        public string PaymentMethod { get; set; }
        
        public string Status { get; set; }
        
        public DateTimeOffset RequestedAt { get; set; }
        
        public DateTimeOffset? ProcessedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
