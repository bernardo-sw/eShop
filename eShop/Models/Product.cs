using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace eShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        [Display(Name = "Name of the Product")]
        public string Name { get; set; }

        [StringLength(250, MinimumLength = 10)]
        [Required]
        [Display(Name = "Short description of the Product")]
        public string ShortDescription { get; set; }

        [MinLength(10)]
        [Display(Name = "Description of the Product")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Price of the Product")]
        [Column(TypeName = "decimal(7,2)")]
        [Range(1, 99999.00)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Weight of the Product in grams")]
        [Range(1, 999.00)]
        public double Weight { get; set; } = 1.0d;

        [Display(Name = "Image URL of the Product")]
        [StringLength(300)]
        public string ImageURL { get; set; }

        [Display(Name = "Image URL of the Product")]
        [StringLength(300)]
        public string ThumbnailURL { get; set; }
        
        [Required]
        [Range(0, 5)]
        public byte Star {  get; set; }

        [Required]
        [Range(0, 100)]
        public byte Discount { get; set; }

        public bool IsFavorite { get; set; }
        
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [NotMapped]
        public decimal DiscountedPrice
        {
            get { return (Discount == 0) ? 0 : (Price - (Price * Discount / 100)); }
        }
    }
}
