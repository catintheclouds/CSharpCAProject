using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class ProductComments
    {
        [Required]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        public string Comments { get; set; }

        public DateTime? ThisDateTime { get; set; }

        public int ProductId { get; set; }

        public int? Rating { get; set; }
        public virtual Product product { get; set; }
    }
}
