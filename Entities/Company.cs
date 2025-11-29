using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Company
    {
        [Key]\n        public int CompanyId { get; set; }
        
        public int EmployerId { get; set; }
        [Required]\n        public string CompanyName { get; set; }
        
        public string? Industry { get; set; }
        
        public string? CompanySize { get; set; }
        
        public string? CommercialRegistrationNumber { get; set; }
        
        public string? CommercialRegistrationFileUrl { get; set; }
        
        public string? Address { get; set; }
        
        public string? Website { get; set; }
        
        public string? LogoUrl { get; set; }
        
        public bool IsVerified { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("EmployerId")]
        public Employer? Employer { get; set; }

    }


}
