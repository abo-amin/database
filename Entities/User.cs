using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class User
    {
        [Key]\n        public int UserId { get; set; }
        [Required]\n        public string Email { get; set; }
        [Required]\n        public string PasswordHash { get; set; }
        
        public string? Phone { get; set; }
        
        public bool IsPhoneVerified { get; set; }
        
        public bool IsEmailVerified { get; set; }
        
        public int FailedLoginAttempts { get; set; }
        
        public DateTimeOffset? LockoutEndDate { get; set; }
        
        public bool TwoFactorEnabled { get; set; }
        
        public string? TwoFactorSecretKey { get; set; }
        
        public string UserType { get; set; }
        
        public DateTimeOffset? LastLoginAt { get; set; }
        
        public DateTimeOffset? LastSeenAt { get; set; }
        
        public bool IsActive { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public int? CreatedBy { get; set; }
        
        public DateTimeOffset? UpdatedAt { get; set; }
        
        public int? UpdatedBy { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }
    }


}
