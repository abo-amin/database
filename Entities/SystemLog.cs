using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class SystemLog
    {
        [Key]\n        public int LogId { get; set; }
        
        public string Level { get; set; }
        
        public string Message { get; set; }
        
        public string? Metadata { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
    }


}
