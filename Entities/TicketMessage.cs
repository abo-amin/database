using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class TicketMessage
    {
        [Key]\n        public int TicketMessageId { get; set; }
        
        public int TicketId { get; set; }
        
        public int SenderUserId { get; set; }
        [Required]\n        public string Message { get; set; }
        
        public DateTimeOffset SentAt { get; set; }

        [ForeignKey("SenderUserId")]
        public User? User { get; set; }

    }


}
