using System.Collections.Generic;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.CategoryService
{
  public interface ICategoryService
  {
    List<Category> Categories { get; set; }

    void LoadCategories();
  }
}