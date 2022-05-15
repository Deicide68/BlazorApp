using Context;
using BlazorShared.Models;
using Microsoft.EntityFrameworkCore;
using BlazorServer.Dtos;


namespace BlazorServer.Services;

public class ProductService : IProductService
{
    private readonly ApplicationDbContext _context;

    public ProductService(ApplicationDbContext _context)
    {
        this._context = _context;
    }

    public async Task<ProductList> GetProducts()
    {
        var items = (await _context.Products.ToListAsync());

        ProductList productList = new ProductList
        {
            Products = items
        };

        return productList;
    }
    
    public async Task AddProduct(Product item)
    {
        Product product = new Product
        {
            Id = new Guid(),
            UserName = item.UserName,
            Model = item.Model,
            ProductPartNumber = item.ProductPartNumber,
            Quantity = item.Quantity,
            Price = item.Price,
            CreatedDate = DateTime.Now
        };

        _context.Products.Add(product);

        await _context.SaveChangesAsync();
    }
}
