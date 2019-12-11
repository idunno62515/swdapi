using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Product;
using SwdApp.Data.Interfaces;

namespace SwdApp.Controllers
{
    [Route("api/products")]
    [ApiController]
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