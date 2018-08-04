using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioTechAPI.Models
{
    [Table("NewsLetterSubscribers")]
    public class NewsLetter
    {
        [Required]
        public int SubscriberID { get; set; }
        
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
