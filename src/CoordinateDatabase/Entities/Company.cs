using System.ComponentModel.DataAnnotations;

namespace CoordinateDatabase.Entities
{
    public class Company
    {

        [Key]
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
