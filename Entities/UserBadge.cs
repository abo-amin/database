using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class UserBadge
    {
        [Key]\n        public int UserId { get; set; }
        [Key]\n        public int BadgeId { get; set; }
        
        public DateTimeOffset AwardedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
