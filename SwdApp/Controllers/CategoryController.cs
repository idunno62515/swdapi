using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Category;
using SwdApp.Data.Interfaces;


namespace SwdApp.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet("MasterCategory")]
        public async Task<IEnumerable<MasterCategoryDto>> GetMasterCategory()
        {
            return await categoryService.GetAllMasterCate();
        }

        [HttpGet("{masterCateId}")]
        public async Task<IEnumerable<CategoryDto>> GetCatesWithProductsByMasterCateId(int masterCateId)
        
        {
            return await categoryService.GetCatesWithProductsByMasterCateId(masterCateId);
        }

        


    }
}