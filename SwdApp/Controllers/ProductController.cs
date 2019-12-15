using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Product;
using SwdApp.Data.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace SwdApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        //[HttpGet("~/api/categories/{cateId}/products")]
        //public async Task<IEnumerable<ProductDto>> GetProductByCate(int cateId)
        //{
        //    return await productService.GetProductByCate(cateId);
        //}

        [HttpGet()]
        public async Task<IEnumerable<ProductDto>> GetProductByCate([FromQuery(Name ="cate")]int cate)
        {
            return await productService.GetProductByCate(cate);
        }


    }
}