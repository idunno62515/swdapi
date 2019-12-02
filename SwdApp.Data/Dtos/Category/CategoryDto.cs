using System;
using System.Collections.Generic;
using System.Text;

namespace SwdApp.Data.Dtos.Category { 
    public class CategoryDto
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }
    }
}
