using System;

namespace JobMagnet.Domain.Entities
{
    public class EscrowTransaction : AuditableEntity
    {
        public int EscrowTransactionId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public int FreelancerUserId { get; set; }
        public User Freelancer { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal FeeAmount { get; set; }
        public string TransactionType { get; set; } = null!; // e.g., Deposit, Release, Refund
        public string Status { get; set; } = "Pending"; // e.g., Pending, Complete, Failed
        public string? TransactionReference { get; set; }
    }
}
