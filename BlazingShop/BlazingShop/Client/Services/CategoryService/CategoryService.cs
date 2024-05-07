using System.Collections.Generic;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.CategoryService
{
  public class CategoryService : ICategoryService
  {
    public List<Category> Categories { get; set; } = new();
    
    public void LoadCategories()
    {
      Categories = new List<Category>
      {
        new() { Id = 1, Name = "Book", Url = "books", Icon = "book" },
        new() { Id = 2, Name = "Game", Url = "games", Icon = "aperture" },
        new() { Id = 3, Name = "Film", Url = "films", Icon = "camera-slr" },
      };
    }
  }
}