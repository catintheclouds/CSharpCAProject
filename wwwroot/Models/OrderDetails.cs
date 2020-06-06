using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class OrderDetails
    {
        [Required]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        [Required]
        
        public string OrderID { get; set; }

        [Required]
       
        public int ProductID { get; set; }

        [Required]
        
        public string ActivationCode { get; set; }

        [Required]
        
        public int OrderQty { get; set; }

        [Required]
        [MaxLength(50)]
        public string OrderStatus { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
