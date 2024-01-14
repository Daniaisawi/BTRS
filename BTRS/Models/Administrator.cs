using System.ComponentModel.DataAnnotations;

namespace BTRS.Models
{
    public class Administrator
    {
        [Key]
        public int AdminID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public ICollection<Passenger> passenger{ set; get; }

        public ICollection<BusTrip> Trips { set; get; }
        public ICollection<Bus> buses { set; get; }
    }

}
