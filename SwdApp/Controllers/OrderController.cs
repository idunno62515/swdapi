using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Order;
using SwdApp.Data.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace SwdApp.Controllers
{
    [Route("api/orders")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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

        [HttpGet]
        public async Task<OrderDto> GetOrderByTable([FromQuery(Name = "tableId")]int tableId)
        {
            return await orderService.GetOrderByTable(tableId);
        }

        [HttpPatch]
        public async Task<bool> RequestPayment([FromQuery(Name = "id")] int id)
        {
            return await orderService.ChangeOrderStatus(id);
        }
    }
}