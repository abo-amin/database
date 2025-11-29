using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class ProjectDelivery
    {
        [Key]\n        public int ProjectDeliveryId { get; set; }
        
        public int ProjectId { get; set; }
        
        public string FileUrl { get; set; }
        
        public string? Message { get; set; }
        
        public bool IsApproved { get; set; }
        
        public DateTimeOffset DeliveredAt { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }

    }


}
