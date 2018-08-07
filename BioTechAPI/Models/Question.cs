using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioTechAPI.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserQuestion { get; set; }
    }
}
