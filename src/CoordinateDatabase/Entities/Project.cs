using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoordinateDatabase.Entities
{
    public class Project
    {

        [Key]
        public int ProjectId { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        public int? ResponsibleUserId { get; set; }


        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        [ForeignKey("TypeId")]
        public virtual ProjectType Type { get; set; }

        [ForeignKey("ResponsibleUserId")]
        public virtual User ResponsibleUser { get; set; }

    }
}
