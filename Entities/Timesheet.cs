using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class Timesheet
    {
        [Key]\n        public int TimesheetId { get; set; }
        
        public int ProjectId { get; set; }
        
        public int FreelancerUserId { get; set; }
        
        public decimal Hours { get; set; }
        
        public DateTimeOffset Date { get; set; }
        
        public string? Description { get; set; }

        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }

        [ForeignKey("FreelancerUserId")]
        public User? User { get; set; }

    }


}
