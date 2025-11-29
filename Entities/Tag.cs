using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Tag
    {
        [Key]\n        public int TagId { get; set; }
        [Required]\n        public string Name { get; set; }
    }


}
