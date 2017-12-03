using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoordinateDatabase.Entities
{
    public class Resource
    {

        [Key]
        public int ResourceId { get; set; }

        public int? UserId { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
