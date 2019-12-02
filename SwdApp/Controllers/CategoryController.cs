using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Category;
using SwdApp.Data.Interfaces;


namespace SwdApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet("MasterCategory")]
        public Task<MasterCategoryDto> GetMasterCategory()
        {
            return null;
        }

        


    }
}