using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnetAPI.Models
{
    public class EscrowTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionID { get; set; }

        [Required]
        public int ProjectID { get; set; }

        [Required]
        public int ClientUserID { get; set; }

        [Required]
        public int FreelancerUserID { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? ReleasedAt { get; set; }

        // Navigation properties
        [ForeignKey(nameof(ProjectID))]
        public Project Project { get; set; }

        [ForeignKey(nameof(ClientUserID))]
        public User ClientUser { get; set; }

        [ForeignKey(nameof(FreelancerUserID))]
        public User FreelancerUser { get; set; }

        public ICollection<Dispute> Disputes { get; set; } = new List<Dispute>();
    }
}
