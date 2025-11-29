using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class IpBlacklist
    {
        [Key]\n        public int IPId { get; set; }
        [Required]\n        public string IpAddress { get; set; }
        
        public string? Reason { get; set; }
        
        public DateTimeOffset BlockedAt { get; set; }
        
        public DateTimeOffset? ExpiresAt { get; set; }
    }


}
