using System.ComponentModel.DataAnnotations;

namespace RideMe.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Seat { get; set; }
        public int Doors { get; set; }
        public string Shift { get; set; }
        public string Fuel { get; set; }
        public decimal DailyRate { get; set; }
        public bool Available { get; set; }
    }
}
