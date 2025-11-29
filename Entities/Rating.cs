using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Rating
    {
        [Key]\n        public int RatingId { get; set; }
        
        public int UserId { get; set; }
        
        public double AverageRating { get; set; }
        
        public int TotalReviews { get; set; }
        
        public DateTimeOffset UpdatedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
