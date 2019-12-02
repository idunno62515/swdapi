using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyCaching.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwdApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        private IEasyCachingProvider easyCachingProvider;
        private IEasyCachingProviderFactory easyCachingProviderFactory;

        public RedisController(IEasyCachingProviderFactory easyCachingProviderFactory)
        {
            this.easyCachingProviderFactory = easyCachingProviderFactory;
            this.easyCachingProvider = easyCachingProviderFactory.GetCachingProvider("redis1");
        } 

        [HttpGet("Set")]
        public IActionResult SetItemInQueue()
        {
            this.easyCachingProvider.Set("TestKey123", "MyValue", TimeSpan.FromDays(100));
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult GetItemInQueue()
        {
            var item = this.easyCachingProvider.Get<string>("TestKey123");
            return Ok(item);
        }
    }
}