using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class CommunityPost
    {
        [Key]\n        public int CommunityPostId { get; set; }
        
        public int PostedByUserId { get; set; }
        [Required]\n        public string Title { get; set; }
        [Required]\n        public string Content { get; set; }
        
        public string? PostType { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("PostedByUserId")]
        public User? User { get; set; }

    }


}
