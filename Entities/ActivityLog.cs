using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class ActivityLog
    {
        [Key]\n        public int ActivityId { get; set; }
        
        public int? UserId { get; set; }
        
        public string Action { get; set; }
        
        public string? Details { get; set; }
        
        public string? IpAddress { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
