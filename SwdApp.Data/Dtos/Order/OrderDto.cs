using System;
using System.Collections.Generic;
using System.Text;

namespace SwdApp.Data.Dtos.Order
{
    public class OrderDto
    {
        public double TotalAmount { get; set; }
        public int? TableId { get; set; }
        public string ServedPerson { get; set; }
        public IEnumerable<OrderDetailDto> Details { get; set; }
    }
}
