using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnetAPI.Models
{
    public class CommunityPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }

        [Required]
        public int UserId { get; set; }

        public int? ParentPostId { get; set; } // For replies/comments

        [Required]
        [MaxLength(50)]
        public string PostType { get; set; } // e.g., 'Question', 'Article', 'Comment'

        [MaxLength(255)]
        public string? Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(ParentPostId))]
        public CommunityPost? ParentPost { get; set; }

        public ICollection<CommunityPost> Replies { get; set; } = new List<CommunityPost>();
    }
}
