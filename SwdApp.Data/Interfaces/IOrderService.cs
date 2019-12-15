using SwdApp.Data.Dtos.Order;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwdApp.Data.Interfaces
{
    public interface IOrderService
    {
        public Task<bool> SubmitOrder(OrderDto order);
        public Task<OrderDto> GetOrderByTable(int tableId);
        public Task<bool> ChangeOrderStatus(int id);
    }
}
