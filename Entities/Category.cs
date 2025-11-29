using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Category
    {
        [Key]\n        public int CategoryId { get; set; }
        [Required]\n        public string Name { get; set; }
        
        public string? Description { get; set; }
    }


}
