using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class UserDocument
    {
        [Key]\n        public int DocumentId { get; set; }
        
        public int UserId { get; set; }
        [Required]\n        public string DocumentType { get; set; }
        [Required]\n        public string FileUrl { get; set; }
        
        public string? Metadata { get; set; }
        
        public bool IsVerified { get; set; }
        
        public DateTimeOffset UploadedAt { get; set; }
        
        public DateTimeOffset? VerifiedAt { get; set; }
        
        public int? VerifiedBy { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
