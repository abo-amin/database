using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnetAPI.Models
{
    public class UserSkill
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int SkillId { get; set; }

        public int? ProficiencyLevel { get; set; } // 1 to 5

        // Navigation properties
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(SkillId))]
        public Skill Skill { get; set; }
    }
}
