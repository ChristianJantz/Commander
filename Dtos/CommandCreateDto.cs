using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        // CommandID will create by the Database
        [Required]
        [MaxLength(250)]
        public string CommandHowTo { get; set; }
        [Required]
        public string CommandLine { get; set; }
        [Required]
        public string Platform { get; set; }
    }

}