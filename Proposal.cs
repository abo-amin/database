using System;

namespace JobMagnet.Domain.Entities
{
    public class Proposal : AuditableEntity
    {
        public int ProposalId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public int FreelancerUserId { get; set; }
        public User FreelancerUser { get; set; } = null!;
        public decimal ProposedAmount { get; set; }
        public string? CoverLetter { get; set; }
        public int EstimatedDays { get; set; }
        public string Status { get; set; } = "Pending"; // e.g., Pending, Accepted, Rejected
    }
}
