using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Product
    {

        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string? AuthorName { get; set; }
        public string? Description { get; set; }
    }
}
