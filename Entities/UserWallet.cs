using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMagnet.Domain.Entities
{

    public class UserWallet
    {
        [Key]\n        public int WalletId { get; set; }
        
        public int UserId { get; set; }
        
        public decimal Balance { get; set; }
        
        public string Currency { get; set; }
        
        public DateTimeOffset UpdatedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

    }


}
