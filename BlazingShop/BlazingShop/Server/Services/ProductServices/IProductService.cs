using System.Collections.Generic;
using System.Threading.Tasks;
using BlazingShop.Shared;

namespace BlazingShop.Server.Services.ProductServices
{
  public interface IProductService
  {
    Task<List<Product>> GetAllProducts();

    Task<List<Product>> GetProductsByCategory(string categoryUrl);

    Task<Product> GetProduct(int id);
  }
}