using Microsoft.AspNetCore.Mvc;

namespace WebsiteBanHang.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductApiController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productRepository.GetAll();
            return Ok(products);
        }
    }

}
