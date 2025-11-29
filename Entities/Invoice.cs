using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Invoice
    {
        [Key]\n        public int InvoiceId { get; set; }
        
        public int ProjectId { get; set; }
        
        public decimal Amount { get; set; }
        
        public DateTimeOffset? DueDate { get; set; }
        
        public string Status { get; set; }
        
        public string? InvoiceNumber { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }

        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }

    }


}
