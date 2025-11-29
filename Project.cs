using System;
using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    public class Project : AuditableEntity
    {
        public int ProjectId { get; set; }
        public int OwnerUserId { get; set; } // Client who posted the project
        public User OwnerUser { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Budget { get; set; }
        public string Status { get; set; } = "Open"; // e.g., Open, InProgress, Completed, Cancelled
        public int? AssignedFreelancerId { get; set; }
        public User? AssignedFreelancer { get; set; }
        public DateTimeOffset? Deadline { get; set; }

        public ICollection<Proposal> Proposals { get; set; } = new List<Proposal>();
        public ICollection<ProjectDelivery> Deliveries { get; set; } = new List<ProjectDelivery>();
        public ICollection<EscrowTransaction> EscrowTransactions { get; set; } = new List<EscrowTransaction>();
        public ICollection<Dispute> Disputes { get; set; } = new List<Dispute>();
    }
}
