using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioTechAPI.Models
{
    [Table("Positions")]
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Experience { get; set; }
        public string Qualifications { get; set; }
        public string Education { get; set; }
        public string Responsibilites { get; set; }
        public string PostDate { get; set; }
        public string Schedule { get; set; }
    }
}
