using System;
using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    public class User : AuditableEntity
    {
        public int UserId { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string? Phone { get; set; }

        // security
        public bool IsPhoneVerified { get; set; }
        public bool IsEmailVerified { get; set; }
        public int FailedLoginAttempts { get; set; }
        public DateTimeOffset? LockoutEndDate { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string? TwoFactorSecretKey { get; set; }

        // tracking & audit
        public string UserType { get; set; } = null!; // Admin/Employer/Client/Freelancer/JobSeeker
        public DateTimeOffset? LastLoginAt { get; set; }
        public DateTimeOffset? LastSeenAt { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        // New: Primary Address
        public int? PrimaryAddressId { get; set; }
        public Address? PrimaryAddress { get; set; }

        // navigations - Profiles
        public Admin? AdminProfile { get; set; }
        public Employer? EmployerProfile { get; set; }
        public Client? ClientProfile { get; set; }
        public Freelancer? FreelancerProfile { get; set; }
        public JobSeeker? JobSeekerProfile { get; set; }

        // navigations - Collections
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public ICollection<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
        public ICollection<Job> PostedJobs { get; set; } = new List<Job>();
        public ICollection<Project> OwnedProjects { get; set; } = new List<Project>();
        public ICollection<Project> AssignedProjects { get; set; } = new List<Project>();
        public ICollection<Proposal> Proposals { get; set; } = new List<Proposal>();
        public ICollection<Message> SentMessages { get; set; } = new List<Message>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
        public ICollection<UserDocument> Documents { get; set; } = new List<UserDocument>();
        public ICollection<Review> ReviewsWritten { get; set; } = new List<Review>();
        public ICollection<Review> ReviewsReceived { get; set; } = new List<Review>();
        public Rating? Rating { get; set; }
        public UserSettings? Settings { get; set; }
    }
}
