using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnetAPI.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Required]
        public int ClientUserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Budget { get; set; }

        [MaxLength(50)]
        public string? PaymentType { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime PostedAt { get; set; } = DateTime.UtcNow;

        public DateTime? Deadline { get; set; }

        // Navigation properties
        [ForeignKey(nameof(ClientUserId))]
        public User ClientUser { get; set; }

        public ICollection<Proposal> Proposals { get; set; } = new List<Proposal>();
        public ICollection<EscrowTransaction> EscrowTransactions { get; set; } = new List<EscrowTransaction>();
        public ICollection<ProjectDelivery> Deliveries { get; set; } = new List<ProjectDelivery>();
    }
}
