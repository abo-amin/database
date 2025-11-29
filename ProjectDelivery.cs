using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnetAPI.Models
{
    public class ProjectDelivery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeliveryID { get; set; }

        [Required]
        public int ProjectID { get; set; }

        [Required]
        public int FreelancerUserID { get; set; }

        public string? Message { get; set; }

        [MaxLength(2048)]
        public string? AttachmentURL { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = "Submitted";

        // Navigation properties
        [ForeignKey(nameof(ProjectID))]
        public Project Project { get; set; }

        [ForeignKey(nameof(FreelancerUserID))]
        public User FreelancerUser { get; set; }
    }
}
