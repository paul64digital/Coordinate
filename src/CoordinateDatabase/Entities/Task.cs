using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoordinateDatabase.Entities
{
    public class Task
    {

        [Key]
        public int TaskId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        public int? StoryPointId { get; set; } //todo: 1,2,3,5,8,13,20,40,100

        public int? ResponsibleUserId { get; set; }

        public int? ParentTaskId { get; set; }

        public int? Sequence { get; set; }


        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        [ForeignKey("StatusId")]
        public virtual TaskStatus Status { get; set; }

        [ForeignKey("StoryPointId")]
        public virtual StoryPoint StoryPoints { get; set; }

        [ForeignKey("ResponsibleUserId")]
        public virtual User ResponsibleUser { get; set; }

        [ForeignKey("ParentTaskId")]
        public virtual Task ParentTask { get; set; }

    }
}
