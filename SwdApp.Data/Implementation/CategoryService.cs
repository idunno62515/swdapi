using SwdApp.Data.Dtos;
using SwdApp.Data.Dtos.Category;
using SwdApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SwdApp.Data.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly string connectionString;

        public CategoryService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Task<IEnumerable<CategoryDto>> GetAllCate()
        {
            List<CategoryDto> list = null;
            using(var con = new SqlConnection(connectionString))
            {
            }
            return null;
        }

        public Task<IEnumerable<MasterCategoryDto>> GetAllMasterCate()
        {
            throw new NotImplementedException();
        }

       
    }
}