using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Faq
    {
        [Key]\n        public int FaqId { get; set; }
        [Required]\n        public string Question { get; set; }
        [Required]\n        public string Answer { get; set; }
        
        public string? Category { get; set; }
    }


}
