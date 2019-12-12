using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Order;
using SwdApp.Data.Interfaces;

namespace SwdApp.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }


        [HttpPost]
        public async Task<bool> CreateOder([FromBody]OrderDto order)
        {
            var res = await orderService.SubmitOrder(order);
            return res;
        }
    }
}