using System;

namespace JobMagnet.Domain.Entities
{
    public class Freelancer : AuditableEntity
    {
        public int FreelancerId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int? FreelancerLevelId { get; set; }
        public FreelancerLevel? FreelancerLevel { get; set; }
        public decimal? HourlyRate { get; set; }
        public string? Currency { get; set; }
        public int TotalCompletedProjects { get; set; }
        public string? PortfolioUrl { get; set; }
        public string? Bio { get; set; }
        public string? DocumentVerificationUrl { get; set; }
        public bool IsVerified { get; set; } = false;
        public DateTimeOffset? LastActiveAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
