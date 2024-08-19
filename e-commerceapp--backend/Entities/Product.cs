using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PracticeAPI.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]

        public string? name { get; set; } 
        
        public string? category { get; set; }
        public string? Image_url { get; set; }

        public string?  Description{ get; set; }
        public int Price { get; set; }
    }
}
