
using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class AddBookDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        //[Required]
        //[MinLength(6)]
        //[DataType(DataType.Password)] 
        //public string Password { get; set; } = string.Empty;
        //[Required]
        //[EmailAddress]
        //[DataType(DataType.EmailAddress)]

        //public string Email { get; set; } = string.Empty;
        [Required]
        public string? Author { get; set; }
        [Required]
        [Range(100,1000)]
        public decimal Price { get; set; }
    }
}
