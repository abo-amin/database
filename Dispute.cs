using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnetAPI.Models
{
    public class Dispute
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DisputeID { get; set; }

        public int? RelatedTransactionID { get; set; }

        public int? RelatedProjectID { get; set; }

        [Required]
        public int InitiatorUserID { get; set; }

        [Required]
        public int RespondentUserID { get; set; }

        public int? AdminUserID { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = "Open";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? ResolvedAt { get; set; }

        // Navigation properties
        [ForeignKey(nameof(RelatedTransactionID))]
        public EscrowTransaction RelatedTransaction { get; set; }

        [ForeignKey(nameof(RelatedProjectID))]
        public Project RelatedProject { get; set; }

        [ForeignKey(nameof(InitiatorUserID))]
        public User InitiatorUser { get; set; }

        [ForeignKey(nameof(RespondentUserID))]
        public User RespondentUser { get; set; }

        [ForeignKey(nameof(AdminUserID))]
        public User AdminUser { get; set; }
    }
}
