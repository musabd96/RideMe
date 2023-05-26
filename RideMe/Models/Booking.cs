using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideMe.Models
{
    public class Booking
    {
        
        [Key]
        public int Id { get; set; }
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
        public IEnumerable<Car> Cars { get; set; }

        [ForeignKey("Rentals")]
        public int RentalsId { get; set; }
        public Rentals Rentals { get; set; }

        public decimal TotalCost { get; set; }
        public int RentalPeriod { get; set; }
    }
}
