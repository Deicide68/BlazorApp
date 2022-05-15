using BlazorShared.Models;

namespace BlazorClient.Interfaces
{
    public interface IProductService
    {
        public Task AddProduct(Product request);
    }
}