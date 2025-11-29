using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Favorite
    {
        [Key]\n        public int UserId { get; set; }
        [Key]\n        public string EntityType { get; set; }
        [Key]\n        public int EntityId { get; set; }
        
        public DateTimeOffset SavedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
