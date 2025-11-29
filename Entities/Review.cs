using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Review
    {
        [Key]\n        public int ReviewId { get; set; }
        
        public int ReviewerId { get; set; }
        
        public string? ReviewerRole { get; set; }
        
        public int TargetUserId { get; set; }
        
        public string? TargetRole { get; set; }
        
        public string Comment { get; set; }
        
        public byte RatingValue { get; set; }
        
        public string? ContextEntity { get; set; }
        
        public int? ContextEntityId { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("TargetUserId")]
        public User? User { get; set; }

    }


}
