using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Subscription
    {
        [Key]\n        public int SubscriptionId { get; set; }
        
        public int UserId { get; set; }
        [Required]\n        public string PlanName { get; set; }
        
        public decimal Price { get; set; }
        
        public string Currency { get; set; }
        
        public DateTimeOffset StartDate { get; set; }
        
        public DateTimeOffset EndDate { get; set; }
        
        public bool IsActive { get; set; }
        
        public bool AutoRenew { get; set; }
        
        public DateTimeOffset? RenewDate { get; set; }
        
        public int? MaxJobs { get; set; }
        
        public int? MaxProposals { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
