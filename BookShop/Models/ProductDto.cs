using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string BookName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string? AuthorName { get; set; } = string.Empty;
        
        [Required]
        public string? Description { get; set; } = string.Empty;
    }
}
