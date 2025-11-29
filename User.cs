using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnetAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]


        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? LastLogin { get; set; }

        // Navigation properties
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

        public UserProfile Profile { get; set; }
        public ICollection<Job> PostedJobs { get; set; } = new List<Job>();
        public ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
        public ICollection<Project> PostedProjects { get; set; } = new List<Project>();
        public ICollection<Proposal> Proposals { get; set; } = new List<Proposal>();
        public ICollection<EscrowTransaction> InitiatedEscrowTransactions { get; set; } = new List<EscrowTransaction>();
        public ICollection<EscrowTransaction> ReceivedEscrowTransactions { get; set; } = new List<EscrowTransaction>();
        public ICollection<ProjectDelivery> ProjectDeliveries { get; set; } = new List<ProjectDelivery>();
        public ICollection<Dispute> InitiatedDisputes { get; set; } = new List<Dispute>();
        public ICollection<Dispute> RespondedDisputes { get; set; } = new List<Dispute>();
        public ICollection<Dispute> AdminDisputes { get; set; } = new List<Dispute>();
        public ICollection<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
        public ICollection<CommunityPost> CommunityPosts { get; set; } = new List<CommunityPost>();
    }
}
