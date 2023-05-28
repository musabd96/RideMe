using System.ComponentModel.DataAnnotations;

namespace RideMe.Models
{
    public class Rentals
    {
        [Key]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string PickupLocation { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PickupDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]

        public TimeSpan PickupTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]

        public TimeSpan ReturnTime { get; set; }
    }

}
