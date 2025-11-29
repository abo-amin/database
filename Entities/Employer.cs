using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Employer
    {
        [Key]\n        public int EmployerId { get; set; }
        
        public int UserId { get; set; }
        
        public string? BusinessEmail { get; set; }
        
        public bool IsVerified { get; set; }
        
        public string? NationalId { get; set; }
        
        public string? TaxNumber { get; set; }
        
        public string? ContactPerson { get; set; }
        
        public string? ContactPhone { get; set; }
        
        public DateTimeOffset? VerificationRequestedAt { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
