using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Order
    {
        [Required]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        [Required]
        [MaxLength(20)]
        public double TotalPrice { get; set; }

        [Required]
        public DateTime DateOfPurchase { get; set; }
        [Required]
     
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
