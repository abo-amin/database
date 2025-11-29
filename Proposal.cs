using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace JobMagnetAPI.Models
{
    [Index(nameof(ProjectID), nameof(FreelancerUserID), IsUnique = true)]
    public class Proposal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProposalID { get; set; }

        [Required]
        public int ProjectID { get; set; }

        [Required]
        public int FreelancerUserID { get; set; }

        [Required]
        public string ProposalText { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? BidAmount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HourlyRate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = "Submitted";

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [ForeignKey(nameof(ProjectID))]
        public Project Project { get; set; }

        [ForeignKey(nameof(FreelancerUserID))]
        public User FreelancerUser { get; set; }
    }
}
