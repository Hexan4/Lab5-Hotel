namespace Lab5_Hotel.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string GuestName { get; set; }
    }
}
