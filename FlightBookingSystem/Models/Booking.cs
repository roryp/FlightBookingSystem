namespace FlightBookingSystem.Models
{
    public class Booking
    {
        public int ReferenceNumber { get; set; }
        public Flight Flight { get; set; }
        public User User { get; set; }
    }
}
