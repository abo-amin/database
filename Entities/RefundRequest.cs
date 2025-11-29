using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class RefundRequest
    {
        [Key]\n        public int RefundRequestId { get; set; }
        
        public int UserId { get; set; }
        
        public int? TransactionId { get; set; }
        
        public string Reason { get; set; }
        
        public string Status { get; set; }
        
        public DateTimeOffset RequestedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
