using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.CategoryService
{
  public class CategoryService : ICategoryService
  {
    private readonly HttpClient _httpClient;
    public List<Category> Categories { get; set; } = new();

    public CategoryService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }
    
    public async Task LoadCategories()
    {
      Categories = await _httpClient.GetFromJsonAsync<List<Category>>("api/Category");
    }
    
    // Categories = new List<Category>
    // {
    //   new() { Id = 1, Name = "Book", Url = "books", Icon = "book" },
    //   new() { Id = 2, Name = "Game", Url = "games", Icon = "aperture" },
    //   new() { Id = 3, Name = "Film", Url = "films", Icon = "camera-slr" },
    // };
  }
}