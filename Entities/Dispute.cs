using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Dispute
    {
        [Key]\n        public int DisputeId { get; set; }
        
        public int ProjectId { get; set; }
        
        public int RaisedByUserId { get; set; }
        
        public string Reason { get; set; }
        
        public string? EvidenceFileUrl { get; set; }
        
        public string? AdminNotes { get; set; }
        
        public string Status { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public DateTimeOffset? ResolvedAt { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }

        [ForeignKey("RaisedByUserId")]
        public User? User { get; set; }

    }


}
