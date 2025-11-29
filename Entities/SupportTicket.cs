using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class SupportTicket
    {
        [Key]\n        public int TicketId { get; set; }
        
        public int CreatedByUserId { get; set; }
        [Required]\n        public string Subject { get; set; }
        
        public string Status { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }

        [ForeignKey("CreatedByUserId")]
        public User? User { get; set; }

    }


}
