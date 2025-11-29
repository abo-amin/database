using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class UserRole
    {
        [Key]\n        public int UserId { get; set; }
        [Key]\n        public int RoleId { get; set; }
        
        public DateTimeOffset AssignedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
