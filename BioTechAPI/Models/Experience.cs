using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioTechAPI.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        [Required]
        public string Statement { get; set; }

        [ForeignKey("Position")]
        public int PositionFK { get; set; }
        public Position Position { get; set; }
    }
}
