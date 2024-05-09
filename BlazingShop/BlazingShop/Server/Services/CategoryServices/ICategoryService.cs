using System.Collections.Generic;
using System.Threading.Tasks;
using BlazingShop.Shared;

namespace BlazingShop.Server.Services.CategoryServices
{
  public interface ICategoryService
  {
    Task<List<Category>> GetCategories();

    Task<Category> GetCategoryByUrl(string categoryUrl);
  }
}