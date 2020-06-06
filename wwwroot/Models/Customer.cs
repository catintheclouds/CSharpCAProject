using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ShoppingCart.Models
{
    public class Customer
    {
        [Required]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [MaxLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [MaxLength(60)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
       
           
    
    }
}
