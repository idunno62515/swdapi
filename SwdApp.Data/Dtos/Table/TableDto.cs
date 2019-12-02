using System;
using System.Collections.Generic;
using System.Text;

namespace SwdApp.Data.Dtos.Table
{
    public class TableDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Text { get; set; }
        public int? Status { get; set; }
    }
}
