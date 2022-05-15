using BlazorServerApp.Context;
using BlazorServerApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        //public List<Product> ProductList { get; set; } = new List<Product>();
    
        public async Task<List<Product>> GetProducts()
        {
            return (await _context.Products.ToListAsync());


            //ProductList productList = new ProductList
            //{
            //    Products = items
            //};

        }
    }
}
