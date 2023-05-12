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
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public decimal TotalCost { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Car Car { get; set; }
    }
}
