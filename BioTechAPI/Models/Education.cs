using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioTechAPI.Models
{
    [Table("Education")]
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        [Required]
        public string Statement { get; set; }

        [ForeignKey("Position")]
        public int PositionFK { get; set; }
        public Position Position { get; set; }
    }
}
