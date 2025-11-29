using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Message
    {
        [Key]\n        public int MessageId { get; set; }
        
        public int ChatId { get; set; }
        
        public int SenderId { get; set; }
        [Required]\n        public string Content { get; set; }
        
        public bool IsRead { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset SentAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }
    }


}
