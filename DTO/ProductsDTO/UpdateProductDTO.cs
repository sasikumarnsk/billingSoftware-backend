using System.ComponentModel.DataAnnotations;

namespace StoreBilling.DTO.ProductsDTO
{
    public class UpdateProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int productQuantity { get; set; } = 0;
    }
}
