using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Job
    {
        [Key]\n        public int JobId { get; set; }
        
        public int PostedByUserId { get; set; }
        [Required]\n        public string Title { get; set; }
        [Required]\n        public string Description { get; set; }
        
        public string? Location { get; set; }
        
        public string? Type { get; set; }
        
        public decimal? MinSalary { get; set; }
        
        public decimal? MaxSalary { get; set; }
        
        public bool IsActive { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        [Timestamp]\n        public byte[]? RowVersion { get; set; }

        [ForeignKey("PostedByUserId")]
        public User? User { get; set; }

    }


}
