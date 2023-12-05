using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreBilling.DatabaseConfigurations;
using StoreBilling.DTO.ProductsDTO;
using StoreBilling.Models;

namespace StoreBilling.Controllers
{
    [EnableCors()]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDetailsContext _db;
        IMapper _mapper;

        public ProductController(ProductDetailsContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateProductDTO createProductDTO)
        {
            var products = _mapper.Map<Products>(createProductDTO);
            _db.Add(products);
            _db.SaveChanges();
            return Ok(products);
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Products> products = new List<Products>();
            products = _db.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            Products product = _db.Products.FirstOrDefault(x => x.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);

        }

        [HttpPut("update/{id:int}")]
        public IActionResult Update(int id, [FromBody] UpdateProductDTO updateProductDTO)
        {

            Products product = _mapper.Map<Products>(updateProductDTO);
            if(product == null) { return BadRequest(); }
            _db.Update(product);
            _db.SaveChanges();
            return Ok();

        }

        [HttpDelete("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
        
            Products product = _db.Products.FirstOrDefault(x=> x.ProductId == id);
            if(product == null) 
            { return NotFound(); }
            _db.Remove(product);
            _db.SaveChanges();
            return Ok();
        }



    }
}
