using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace JobMagnetAPI.Models
{
    [Index(nameof(JobId), nameof(JobSeekerUserId), IsUnique = true)]
    public class JobApplication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }

        [Required]
        public int JobId { get; set; }

        [Required]
        public int JobSeekerUserId { get; set; }

        public string? CoverLetter { get; set; }

        [MaxLength(2048)]
        public string? CV_URL { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = "Submitted";

        public DateTime AppliedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [ForeignKey(nameof(JobId))]
        public Job Job { get; set; }

        [ForeignKey(nameof(JobSeekerUserId))]
        public User JobSeekerUser { get; set; }
    }
}
