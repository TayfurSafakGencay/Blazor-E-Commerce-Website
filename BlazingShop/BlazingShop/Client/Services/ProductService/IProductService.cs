using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
  public interface IProductService
  {
    List<Product> Products { get; set; }
    
    event Action OnChange;

    Task LoadProducts(string categoryUrl = null);

    Task<Product> GetProduct(int id);
  }
}