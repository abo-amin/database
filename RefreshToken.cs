using System;

namespace JobMagnet.Domain.Entities
{
    public class RefreshToken : AuditableEntity
    {
        public int RefreshTokenId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string Token { get; set; } = null!;
        public DateTimeOffset Expires { get; set; }
        public bool IsRevoked { get; set; } = false;
    }
}
