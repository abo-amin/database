using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Role
    {
        [Key]\n        public int RoleId { get; set; }
        [Required]\n        public string RoleName { get; set; }
        
        public string? Description { get; set; }
    }


}
