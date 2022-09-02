using System.ComponentModel.DataAnnotations;

namespace SixMinAPI.Dtos
{
    public class CommandCreateDto
    {
        // When create a Command, we don't need to pass an Id
        // It'll be created by default
        // [Key]
        // public int Id { get; set; }

        // The decorators are present to validate the data

        [Required]
        public string? HowTo { get; set; }

        [Required]
        [MaxLength(5)]
        public string? Platform { get; set; }

        [Required]
        public string? CommandLine { get; set; }
    }
}