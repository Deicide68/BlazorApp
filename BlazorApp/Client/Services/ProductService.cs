using System.Net.Http.Json;
using BlazorShared.Models;

namespace BlazorClient.Services;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient _httpClient)
    {
        this._httpClient = _httpClient;
    }
    public async Task AddProduct(Product item)
    {
        var response = await _httpClient.PostAsJsonAsync("api/product", item);
        response.EnsureSuccessStatusCode();

        // Exception handling
        // if (response.StatusCode)
        // {
        //     string stringResponse = await response.Content.ReadAsStringAsync();
        //     var message = stringResponse.FromJson<Message>();

        //     return message;
        // }
    }
}
