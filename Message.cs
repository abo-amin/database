using System;

namespace JobMagnet.Domain.Entities
{
    public class Message : AuditableEntity
    {
        public int MessageId { get; set; }
        public int ChatId { get; set; }
        public Chat Chat { get; set; } = null!;
        public int SenderId { get; set; }
        public User Sender { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool IsRead { get; set; } = false;
        public DateTimeOffset SentAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
