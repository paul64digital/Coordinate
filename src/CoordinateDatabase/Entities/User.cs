using System.ComponentModel.DataAnnotations;

namespace CoordinateDatabase.Entities
{
    public class User
    {

        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Username { get; set; }

        [Required]
        [MaxLength(64)]
        public string PasswordHash { get; set; }

        [Required]
        [MaxLength(50)]
        public string Forename { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(50)]
        public string PhoneNumber { get; set; }

    }
}
