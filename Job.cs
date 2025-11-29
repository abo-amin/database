using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnetAPI.Models
{
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }

        [Required]
        public int CompanyUserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [MaxLength(255)]
        public string? Location { get; set; }

        [MaxLength(50)]
        public string? JobType { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? SalaryMin { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? SalaryMax { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime PostedAt { get; set; } = DateTime.UtcNow;

        public DateTime? ExpiresAt { get; set; }

        // Navigation properties
        [ForeignKey(nameof(CompanyUserId))]
        public User CompanyUser { get; set; }

        public ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();
    }
}
