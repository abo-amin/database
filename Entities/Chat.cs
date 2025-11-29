using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Chat
    {
        [Key]\n        public int ChatId { get; set; }
        
        public int User1Id { get; set; }
        
        public int User2Id { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }
    }


}
