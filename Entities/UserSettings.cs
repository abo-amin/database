using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class UserSettings
    {
        [Key]\n        public int UserId { get; set; }
        
        public string Language { get; set; }
        
        public string? TimeZone { get; set; }
        
        public bool EmailNotifications { get; set; }
        
        public bool SmsNotifications { get; set; }
        
        public bool PushNotifications { get; set; }
        
        public bool DarkMode { get; set; }
        
        public string? Preferences { get; set; }
        
        public DateTimeOffset? UpdatedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
