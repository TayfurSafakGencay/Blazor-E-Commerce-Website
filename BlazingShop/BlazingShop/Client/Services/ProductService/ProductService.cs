using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
  public class ProductService : IProductService
  {
    private readonly HttpClient _httpClient;

    public event Action OnChange;
    public List<Product> Products { get; set; } = new();

    public ProductService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    public async Task LoadProducts(string categoryUrl)
    {
      if (categoryUrl == null)
      {
        Products = await _httpClient.GetFromJsonAsync<List<Product>>($"api/Product");
      }
      else
      {
        Products = await _httpClient.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
      }

      OnChange?.Invoke();
    }

    public async Task<Product> GetProduct(int id)
    {
      return await _httpClient.GetFromJsonAsync<Product>($"api/Product/{id}");
    }
  }
}