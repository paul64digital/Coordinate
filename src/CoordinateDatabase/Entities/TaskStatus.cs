using System.ComponentModel.DataAnnotations;

namespace CoordinateDatabase.Entities
{
    public class TaskStatus
    {

        [Key]
        public int TaskStatusId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
