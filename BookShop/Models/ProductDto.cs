using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string BookName { get; set; }
        
        [Required, MaxLength(100)]
        public string? AuthorName { get; set; }
        
        [Required]
        public string? Description { get; set; }
    }
}
