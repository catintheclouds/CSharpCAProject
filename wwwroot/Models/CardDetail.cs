using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class CardDetail
    {
        [Required]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string ExD { get; set; }

        [MaxLength(30)]
        public string Code { get; set; }

        [MaxLength(30)]
        public string CCV { get; set; }

        
        [MaxLength(30)]
        public string Address { get; set; }

      
    }
}
