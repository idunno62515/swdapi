using System;
using System.Collections.Generic;
using System.Text;

namespace SwdApp.Data.Dtos.Order
{
    public class OrderDetailDto
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double TotalAmount { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
        public double UnitPrice { get; set; }

    }
}
