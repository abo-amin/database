using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class UserCertification
    {
        [Key]\n        public int CertificationId { get; set; }
        
        public int UserId { get; set; }
        [Required]\n        public string CertificationName { get; set; }
        
        public string? IssuedBy { get; set; }
        
        public DateTimeOffset? IssuedDate { get; set; }
        
        public DateTimeOffset? ExpiryDate { get; set; }
        
        public string? CertificateUrl { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
