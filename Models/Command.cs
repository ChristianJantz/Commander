using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int CommandID { get; set; }
        [Required]
        [MaxLength(250)]
        public string CommandHowTo { get; set; }
        [Required]
        public string CommandLine { get; set; }
        [Required]
        [MaxLength(250)]
        public string Platform { get; set; }
    }

}