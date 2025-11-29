using System;

namespace JobMagnet.Domain.Entities
{
    public class Subscription : AuditableEntity
    {
        public int SubscriptionId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string PlanName { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTimeOffset StartDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset EndDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
