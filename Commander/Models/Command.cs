using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command 
    {
        // Type prop then press tab for quick code generation.
        // Then edit the line to meet your requirement(s).

        // key annonation not required but we are going to go ahead and put it.
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
} 