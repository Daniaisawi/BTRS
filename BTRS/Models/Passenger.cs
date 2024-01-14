using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTRS.Models
{
    public class Passenger

    {
       
        [Key]
        public int PassengerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public String PhoneNumber { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
      
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


        [ForeignKey("Admin_ID")]
        public Administrator admin { get; set; }
        public ICollection<Booking> booking { get; set; }





    }
}
