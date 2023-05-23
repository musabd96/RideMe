using System.ComponentModel.DataAnnotations;

namespace RideOn.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public int UserId { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required]
        public string PickUpLocation { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime PickUpTime { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime ReturnTime { get; set; }
        [Required]
        public decimal TotalCost { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Car Car { get; set; }
    }
}
