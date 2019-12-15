using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Category;
using SwdApp.Data.Interfaces;


namespace SwdApp.Controllers
{
    [Route("api/categories")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }


        [HttpGet("~/api/master-categories")]
        public async Task<IEnumerable<MasterCategoryDto>> GetMasterCategory()
        {
            return await categoryService.GetAllMasterCate();
        }

        [HttpGet()]
        public async Task<IEnumerable<CategoryDto>> GetCatesWithProductsByMasterCateId
            (
                [FromQuery(Name = "mastercate")]int masterCateId
            )
        
        {
            return await categoryService.GetCatesWithProductsByMasterCateId(masterCateId);
        }

        


    }
}