using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Skill
    {
        [Key]\n        public int SkillId { get; set; }
        [Required]\n        public string Name { get; set; }
    }


}
