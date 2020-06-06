using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Product
    {       
        [Required]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Required]
        [MaxLength(120)]
        public string Description { get; set; }
        [Required]
        [MaxLength(20)]
        public double Price { get; set; }
        [MaxLength(20)]
        public string Category { get; set; }
        [Required]
        [MaxLength(20)]
        public string Brand { get; set; }
        [Required]
        [MaxLength(200)]
        public string ImageURL { get; set; }
       
        public virtual ICollection<ProductComments> ProductComments { get; set; }

    }
}
