using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingShop.Server.Services.CategoryServices;
using BlazingShop.Shared;

namespace BlazingShop.Server.Services.ProductServices
{
  public class ProductService : IProductService
  {
    private readonly ICategoryService _categoryService;

    public ProductService(ICategoryService categoryService)
    {
      _categoryService = categoryService;
    }
    public async Task<List<Product>> GetAllProducts()
    {
      return Products;
    }

    public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
    {
      Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
      return Products.Where(p => p.CategoryId == category.Id).ToList();
    }

    public async Task<Product> GetProduct(int id)
    {
      Product product = Products.FirstOrDefault(p => p.Id == id);
      return product;
    }
    
    public List<Product> Products { get; set; } = new()
    {
      new Product
      {
        Id = 1,
        CategoryId = 3,
        Title = "Guide to the Galaxy",
        Description = "It is a comedy science fiction series.",
        Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
        Price = 9.99m,
        OriginalPrice = 19.99m
      },

      new Product
      {
        Id = 2,
        CategoryId = 2,
        Title = "Half Life 2",
        Description =
          "Half-Life 2 is a 2004 first-person shooter (FPS) game developed and published by Valve Corporation. It was published for Windows on Valve's digital distribution service, Steam. Like the original Half-Life (1998), Half-Life 2 combines shooting, puzzles, and storytelling, and adds new features such as vehicles and physics-based gameplay. The player controls Gordon Freeman, who joins a resistance to liberate Earth from the Combine, an interplanetary alien empire.",
        Image = "https://upload.wikimedia.org/wikipedia/tr/0/05/421px-HL2box.jpg",
        Price = 11.99m,
        OriginalPrice = 30.00m
      }
    };
  }
}