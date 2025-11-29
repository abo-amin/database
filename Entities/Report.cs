using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Report
    {
        [Key]\n        public int ReportId { get; set; }
        
        public int ReportedBy { get; set; }
        
        public string EntityType { get; set; }
        
        public int EntityId { get; set; }
        
        public string Reason { get; set; }
        
        public string? Details { get; set; }
        
        public string Status { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
    }


}
