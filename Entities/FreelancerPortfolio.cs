using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class FreelancerPortfolio
    {
        [Key]\n        public int PortfolioId { get; set; }
        
        public int FreelancerId { get; set; }
        [Required]\n        public string ProjectTitle { get; set; }
        
        public string? Description { get; set; }
        
        public string? ImageUrlsJson { get; set; }
        
        public string? ProjectUrl { get; set; }
        
        public string? ClientName { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }

        [ForeignKey("FreelancerId")]
        public Freelancer? Freelancer { get; set; }

    }


}
