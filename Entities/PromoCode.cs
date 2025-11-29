using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class PromoCode
    {
        [Key]\n        public int PromoCodeId { get; set; }
        [Required]\n        public string Code { get; set; }
        
        public decimal? DiscountPercent { get; set; }
        
        public DateTimeOffset? ExpiryDate { get; set; }
        
        public int? UsageLimit { get; set; }
    }


}
