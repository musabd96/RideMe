using System.ComponentModel.DataAnnotations;

namespace RideOn.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal DailyRate { get; set; }
        public bool Available { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
