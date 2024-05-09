using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingShop.Shared;

namespace BlazingShop.Server.Services.CategoryServices
{
  public class CategoryService : ICategoryService
  {
    public List<Category> Categories { get; set; } = new()
    {
      new Category { Id = 1, Name = "Book", Url = "books", Icon = "book" },
      new Category { Id = 2, Name = "Game", Url = "games", Icon = "aperture" },
      new Category { Id = 3, Name = "Film", Url = "films", Icon = "camera-slr" },
    };
    
    public async Task<List<Category>> GetCategories()
    {
      return Categories;
    }

    public async Task<Category> GetCategoryByUrl(string categoryUrl)
    {
      return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
    }
  }
}