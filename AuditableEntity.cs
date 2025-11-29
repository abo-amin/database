using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{
    // Base class for audit fields
    public abstract class AuditableEntity
    {
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public int? CreatedBy { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        [NotMapped] // RowVersion is typically configured in OnModelCreating
        public byte[]? RowVersion { get; set; }
    }
}
