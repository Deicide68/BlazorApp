using Microsoft.AspNetCore.Mvc;
using BlazorShared.Models;
using BlazorServer.Dtos;

namespace BlazorServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;   

        //DI the data context
        public ProductController(IProductService _productService)
        {
            this._productService = _productService;
        }

        [HttpGet]
        public async Task<ProductList> GetProductsAsync()
        {
            var items = await _productService.GetProducts();

            return items;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProductsAsync(Product request)
        {
            await _productService.AddProduct(request);

            return Ok(new
            {
                message = "Product added successfully."
            });
        }

        //Can add more 
    }
}