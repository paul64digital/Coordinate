using System.ComponentModel.DataAnnotations;

namespace CoordinateDatabase.Entities
{
    public class ProjectType
    {

        [Key]
        public int ProjectTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
