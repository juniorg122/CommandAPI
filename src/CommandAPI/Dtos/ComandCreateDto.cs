using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Dtos
{
    public class CommandCreateDto
    {
        [MaxLength(250)]
        [Required]
        public string HowTO { get; set; }
        
        [Required]
        public string Platform { get; set; }
        [Required]
        public string CommandLine { get; set; }

    }
}