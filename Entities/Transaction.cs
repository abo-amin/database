using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Transaction
    {
        [Key]\n        public int TransactionId { get; set; }
        
        public int UserId { get; set; }
        
        public string Type { get; set; }
        
        public decimal Amount { get; set; }
        
        public string? Status { get; set; }
        
        public string? Description { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
