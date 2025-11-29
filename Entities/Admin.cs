using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Admin
    {
        [Key]\n        public int AdminId { get; set; }
        
        public int UserId { get; set; }
        
        public byte AdminLevel { get; set; }
        
        public string? PermissionsJson { get; set; }
        
        public string? Notes { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
