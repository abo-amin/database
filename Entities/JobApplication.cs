using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class JobApplication
    {
        [Key]\n        public int JobApplicationId { get; set; }
        
        public int JobId { get; set; }
        
        public int JobSeekerId { get; set; }
        
        public string? ResumeUrl { get; set; }
        
        public string? CoverLetter { get; set; }
        
        public string Status { get; set; }
        
        public DateTimeOffset AppliedAt { get; set; }
        
        public bool IsDeleted { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("JobId")]
        public Job? Job { get; set; }

    }


}
