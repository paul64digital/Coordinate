using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoordinateDatabase.Entities
{
    public class Requirement
    {

        [Key]
        public int RequirementId { get; set; }

        [Required]
        public int RequirementType { get; set; }

        [Required]
        public int ParentTaskId { get; set; }

        public int? TaskId { get; set; }

        public int? SkillId { get; set; }

        public int? ResourceId { get; set; }


        [ForeignKey("ParentTaskId")]
        public virtual Task ParentTask { get; set; }

        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }

        [ForeignKey("SkillId")]
        public virtual Skill Skill { get; set; }

        [ForeignKey("ResourceId")]
        public virtual Resource Resource { get; set; }

    }
}
