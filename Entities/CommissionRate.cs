using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class CommissionRate
    {
        [Key]\n        public int CommissionRateId { get; set; }
        
        public string UserType { get; set; }
        
        public decimal RatePercent { get; set; }
        
        public DateTimeOffset EffectiveDate { get; set; }
    }


}
