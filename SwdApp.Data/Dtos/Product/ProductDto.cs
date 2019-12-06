using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SwdApp.Data.Dtos.Product
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string ProCode { get; set; }

        public string ProductName { get; set; }

        public string ProShortName { get; set; }

        public double Price { get; set; }

        public string PicURL { get; set; }

        public bool IsAvailable { get; set; }

        public double DiscountPercent { get; set; }

        public double DiscountPrice { get; set; }

        public string Att1 { get; set; }

        public string Att2 { get; set; }

        public string Att3 { get; set; }

    }
}
