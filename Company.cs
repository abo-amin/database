using System.Collections.Generic;

namespace JobMagnet.Domain.Entities
{
    public class Company : AuditableEntity
    {
        public int CompanyId { get; set; }
        public int EmployerId { get; set; }
        public Employer Employer { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string? Industry { get; set; }
        public string? CompanySize { get; set; }
        public string? CommercialRegistrationNumber { get; set; }
        public string? CommercialRegistrationFileUrl { get; set; }
        // Modified: Replaced string Address with AddressId
        public int? AddressId { get; set; }
        public Address? CompanyAddress { get; set; }
        public string? Website { get; set; }
        public string? LogoUrl { get; set; }
        public bool IsVerified { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        
        public ICollection<Job> PostedJobs { get; set; } = new List<Job>();
    }
}
