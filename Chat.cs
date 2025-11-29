using System;
using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    public class Chat : AuditableEntity
    {
        public int ChatId { get; set; }
        public int User1Id { get; set; }
        public User User1 { get; set; } = null!;
        public int User2Id { get; set; }
        public User User2 { get; set; } = null!;
        public DateTimeOffset LastMessageAt { get; set; } = DateTimeOffset.UtcNow;

        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
