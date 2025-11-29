using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Freelancer
    {
        [Key]\n        public int FreelancerId { get; set; }
        
        public int UserId { get; set; }
        
        public int? FreelancerLevelId { get; set; }
        
        public decimal? HourlyRate { get; set; }
        
        public string? Currency { get; set; }
        
        public int TotalCompletedProjects { get; set; }
        
        public string? PortfolioUrl { get; set; }
        
        public string? Bio { get; set; }
        
        public string? DocumentVerificationUrl { get; set; }
        
        public bool IsVerified { get; set; }
        
        public DateTimeOffset? LastActiveAt { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
