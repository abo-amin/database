namespace JobMagnet.Domain.Entities
{
    public class Payment : AuditableEntity
    {
        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal FeeAmount { get; set; }
        public string Currency { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
        public string TransactionType { get; set; } = null!; // e.g., Deposit, Withdrawal, ServiceFee
        public string Status { get; set; } = "Completed";
        public string? TransactionReference { get; set; }
    }
}
