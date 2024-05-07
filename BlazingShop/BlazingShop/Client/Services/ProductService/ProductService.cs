using System.Collections.Generic;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
  public class ProductService : IProductService
  {
    public List<Product> Products { get; set; } = new();
    
    public void LoadProducts()
    {
      Products = new List<Product>
      {
        new()
        {
          Id = 1,
          CategoryId = 3,
          Title = "Guide to the Galaxy",
          Description = "It is a comedy science fiction series.",
          Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
          Price = 9.99m,
          OriginalPrice = 19.99m
        },

        new()
        {
          Id = 2,
          CategoryId = 2,
          Title = "Half Life 2",
          Description = "Half-Life 2 is a 2004 first-person shooter (FPS) game developed and published by Valve Corporation. It was published for Windows on Valve's digital distribution service, Steam. Like the original Half-Life (1998), Half-Life 2 combines shooting, puzzles, and storytelling, and adds new features such as vehicles and physics-based gameplay. The player controls Gordon Freeman, who joins a resistance to liberate Earth from the Combine, an interplanetary alien empire.",
          Image = "https://upload.wikimedia.org/wikipedia/tr/0/05/421px-HL2box.jpg",
          Price = 11.99m,
          OriginalPrice = 30.00m
        }
      };
    }
  }
}