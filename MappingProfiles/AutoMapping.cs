using AutoMapper;
using StoreBilling.DTO.ProductsDTO;
using StoreBilling.Models;

namespace StoreBilling.MappingProfiles
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<Products, CreateProductDTO>().ReverseMap();
            CreateMap<Products, UpdateProductDTO>().ReverseMap(); 
        }
    }
}
