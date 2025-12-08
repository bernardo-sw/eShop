using System.ComponentModel.DataAnnotations;

namespace eShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        [Display(Name = "Category name")]
        public string Name { get; set; }

        [StringLength(250, MinimumLength = 10)]
        [Required]
        [Display(Name = "Category description")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
