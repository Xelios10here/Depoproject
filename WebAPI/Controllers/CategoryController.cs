using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpPost("add")]
        public void CategoryAdd(Category category)
        {
            _categoryService.CategoryAdd(category);

        }

        [HttpGet("getall")]
        public List<Category> GetAll()
        {
            var result = _categoryService.GetAll();
            return result;
        }
    }
}
