using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class BlockedUser
    {
        [Key]\n        public int BlockId { get; set; }
        
        public int BlockedByUserId { get; set; }
        
        public int BlockedUserId { get; set; }
        
        public string? Reason { get; set; }
        
        public DateTimeOffset BlockedAt { get; set; }

        [ForeignKey("BlockedByUserId")]
        public User? User { get; set; }

        [ForeignKey("BlockedUserId")]
        public User? User { get; set; }

    }


}
