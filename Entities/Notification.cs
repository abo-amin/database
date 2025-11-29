using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Notification
    {
        [Key]\n        public int NotificationId { get; set; }
        
        public int UserId { get; set; }
        
        public string Title { get; set; }
        
        public string Message { get; set; }
        
        public string? NotificationType { get; set; }
        
        public string? RedirectUrl { get; set; }
        
        public string? ImageUrl { get; set; }
        
        public bool IsRead { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
