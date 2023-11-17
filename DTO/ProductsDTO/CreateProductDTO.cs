using System.ComponentModel.DataAnnotations;

namespace StoreBilling.DTO.ProductsDTO
{
    public class CreateProductDTO
    {
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int productQuantity { get; set; } = 0;
    }
}
