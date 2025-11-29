using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Announcement
    {
        [Key]\n        public int AnnouncementId { get; set; }
        [Required]\n        public string Title { get; set; }
        [Required]\n        public string Content { get; set; }
        
        public string? TargetUsers { get; set; }
        
        public DateTimeOffset? ExpiryDate { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }
    }


}
