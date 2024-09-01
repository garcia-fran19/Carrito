using Shared.Models;
using System.Net.Http.Json;

namespace Carrito.Client.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            // Cambia la URL según la opción de API que uses
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/products");
            // O para archivo local
            // return await _httpClient.GetFromJsonAsync<List<Product>>("products.json");
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            // Cambia la URL según la opción de API que uses
            return await _httpClient.GetFromJsonAsync<Product>($"api/products/{id}");
            // O para archivo local
            // var products = await GetProductsAsync();
            // return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
