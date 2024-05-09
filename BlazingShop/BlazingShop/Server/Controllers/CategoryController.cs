using System.Collections.Generic;
using System.Threading.Tasks;
using BlazingShop.Server.Services.CategoryServices;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategories());
        }
    }
}