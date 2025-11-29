using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class UserSkill
    {
        [Key]\n        public int UserId { get; set; }
        [Key]\n        public int SkillId { get; set; }
        
        public int? ProvenYears { get; set; }
        
        public string? CertificateUrl { get; set; }
        
        public int? VerifiedBy { get; set; }
        
        public DateTimeOffset? VerifiedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
