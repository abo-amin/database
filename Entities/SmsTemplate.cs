using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class SmsTemplate
    {
        [Key]\n        public int SmsTemplateId { get; set; }
        [Required]\n        public string TemplateName { get; set; }
        [Required]\n        public string Body { get; set; }
        
        public string? VariablesJson { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
    }


}
