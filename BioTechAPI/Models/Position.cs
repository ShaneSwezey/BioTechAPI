using System;
using System.Collections.Generic;
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
        public string PositionStatement { get; set; }
        [Column(TypeName = "date")]
        public DateTime PostDate { get; set; }
        public string Schedule { get; set; }


        public ICollection<Responsibility> Responsibilites { get; set; }
        public ICollection<Qualification> Qualifications { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Education> Education { get; set; }
    }
}
