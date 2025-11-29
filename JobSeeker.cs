using System;

namespace JobMagnet.Domain.Entities
{
    public class JobSeeker : AuditableEntity
    {
        public int JobSeekerId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string? CVUrl { get; set; }
        public int? ExperienceYears { get; set; }
        public string? PreferredJobType { get; set; }
        public string? Bio { get; set; }
        public bool IsVerified { get; set; } = false;
        public DateTimeOffset? LastActiveAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        
        // New: JobSeeker Address
        public int? AddressId { get; set; }
        public Address? JobSeekerAddress { get; set; }
    }
}
