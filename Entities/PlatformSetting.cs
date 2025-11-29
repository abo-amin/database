using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class PlatformSetting
    {
        [Key]\n        public int SettingId { get; set; }
        [Required]\n        public string SettingKey { get; set; }
        [Required]\n        public string SettingValue { get; set; }
        
        public string? Category { get; set; }
        
        public DateTimeOffset? UpdatedAt { get; set; }
    }


}
