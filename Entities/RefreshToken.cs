using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class RefreshToken
    {
        [Key]\n        public int TokenId { get; set; }
        
        public int UserId { get; set; }
        [Required]\n        public string Token { get; set; }
        
        public DateTimeOffset ExpiresAt { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public string? CreatedByIp { get; set; }
        
        public DateTimeOffset? RevokedAt { get; set; }
        
        public string? ReplacedByToken { get; set; }
        
        public string? ReasonRevoked { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
