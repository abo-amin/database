using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Client
    {
        [Key]\n        public int ClientId { get; set; }
        
        public int UserId { get; set; }
        
        public string? LegalName { get; set; }
        
        public string? ContactPhone { get; set; }
        
        public string? Address { get; set; }
        
        public string? IdentityDocumentUrl { get; set; }
        
        public bool IsVerified { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
