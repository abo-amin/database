using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class SearchHistory
    {
        [Key]\n        public int SearchId { get; set; }
        
        public int? UserId { get; set; }
        [Required]\n        public string QueryText { get; set; }
        
        public string? Filters { get; set; }
        
        public int? ResultsCount { get; set; }
        
        public DateTimeOffset ExecutedAt { get; set; }
        
        public string? IpAddress { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
