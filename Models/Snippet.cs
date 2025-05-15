using System.ComponentModel.DataAnnotations;

namespace snipsvault.Models
{
    public class Snippet
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Language { get; set; }

        public string? Tags { get; set; }

        public string? Description { get; set; }

        [Required]
        public string? Code { get; set; }
    }
}
