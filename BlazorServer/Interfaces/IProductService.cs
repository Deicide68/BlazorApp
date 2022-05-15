using BlazorServerApp.Data;

namespace BlazorServerApp.Interfaces
{
    public interface IProductService
    {
        //List<Product> ProductList { get; set; }
        public Task<List<Product>> GetProducts();
    }
}
