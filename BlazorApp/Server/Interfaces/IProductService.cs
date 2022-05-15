using BlazorShared.Models;
using BlazorServer.Dtos;

namespace BlazorServer.Interfaces
{
    public interface IProductService
    {
        public Task<ProductList> GetProducts();

        public Task AddProduct(Product request);
    }
}