using System.ComponentModel.DataAnnotations;

namespace ProductsMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(500)]
        public string ProductDescription { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductCategory { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double ProductPrice { get; set; }

        [Required]
        [StringLength(100)]
        public int Stock { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
