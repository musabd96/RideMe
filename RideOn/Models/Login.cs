using System.ComponentModel.DataAnnotations;

namespace RideOn.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
