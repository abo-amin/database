using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class ErrorLog
    {
        [Key]\n        public int ErrorId { get; set; }
        
        public string ExceptionMessage { get; set; }
        
        public string? StackTrace { get; set; }
        
        public string? RequestBody { get; set; }
        
        public string? Url { get; set; }
        
        public int? UserId { get; set; }
        
        public DateTimeOffset LoggedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
