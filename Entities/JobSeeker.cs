using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class JobSeeker
    {
        [Key]\n        public int JobSeekerId { get; set; }
        
        public int UserId { get; set; }
        
        public string? CVUrl { get; set; }
        
        public int? ExperienceYears { get; set; }
        
        public string? PreferredJobType { get; set; }
        
        public string? Bio { get; set; }
        
        public bool IsVerified { get; set; }
        
        public DateTimeOffset? LastActiveAt { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
