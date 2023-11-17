using System.ComponentModel.DataAnnotations;

namespace StoreBilling.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int productQuantity { get; set; } = 0;

    }
}
