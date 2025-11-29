using System;
using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    public class Employer : AuditableEntity
    {
        public int EmployerId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string? BusinessEmail { get; set; }
        public bool IsVerified { get; set; } = false;
        public string? NationalId { get; set; }
        public string? TaxNumber { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPhone { get; set; }
        public DateTimeOffset? VerificationRequestedAt { get; set; }

        public ICollection<Company> Companies { get; set; } = new List<Company>();
    }
}
