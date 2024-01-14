using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTRS.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }


        [ForeignKey("Passenger_ID")]
        public Passenger passenger { get; set; }

        [ForeignKey("BusTrip_ID")]
        public BusTrip Trips { get; set; }
    }
}
