using SwdApp.Data.Dtos.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SwdApp.Data.Dtos.Category { 
    public class CategoryDto
    {
        public int Id { get; set; }

        public int CateCode { get; set; }

        public string Name { get; set; }

        public string CateShortName { get; set; }

        public List<ProductDto> Products { get; set; }
    }
}
