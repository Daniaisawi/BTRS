using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTRS.Models
{
    public class Bus
    {
        [Key]
        public int BusID { get; set; }
        [Required]
        public string CaptainName { get; set; }
        [Required]
        public int NumberOfSeats { get; set; }
        [ForeignKey("BusTrip_ID")]
      
       
        public BusTrip Trips { get; set; }

        [ForeignKey("Admin_ID")]
        public Administrator admin { get; set; }
       
    }
}
