using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Referral
    {
        [Key]\n        public int ReferralId { get; set; }
        
        public int ReferrerId { get; set; }
        
        public int ReferredUserId { get; set; }
        
        public string? Status { get; set; }
        
        public decimal? RewardAmount { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }

        [ForeignKey("ReferredUserId")]
        public User? User { get; set; }

    }


}
