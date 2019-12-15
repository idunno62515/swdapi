using Dapper;
using SwdApp.Data.Dtos;
using SwdApp.Data.Dtos.Category;
using SwdApp.Data.Dtos.Product;
using SwdApp.Data.Interfaces;
using System;
using System.Linq;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SwdApp.Data.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly string connectionString;

        public CategoryService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<IEnumerable<CategoryDto>> GetCatesWithProductsByMasterCateId(int masterCateId = -1)
        {
            IEnumerable<CategoryDto> list = null;
            var cateDictionary = new Dictionary<int, CategoryDto>();
            using (var con = new SqlConnection(connectionString))
            {
                list = await con.QueryAsync<CategoryDto, ProductDto, CategoryDto>(
                    "spCateGetCateAndProductByMasterCateId",
                    (cate, products) =>
                    {
                        CategoryDto cateEntry;
                        if (!cateDictionary.TryGetValue(cate.Id, out cateEntry))
                        {
                            cateEntry = cate;
                            cateEntry.Products = new List<ProductDto>();
                            cateDictionary.Add(cateEntry.Id, cateEntry);
                        }

                        cateEntry.Products.Add(products);
                        return cateEntry;
                    },
                     new { MasterCateId = masterCateId },
                     splitOn: "ProductId",
                     commandType: CommandType.StoredProcedure);
            }
            return cateDictionary.Values;
        }




        public async Task<IEnumerable<MasterCategoryDto>> GetAllMasterCate()
        {
            IEnumerable<MasterCategoryDto> list = null;
            using (var con = new SqlConnection(connectionString))
            {
                list = await con.QueryAsync<MasterCategoryDto>(
                    "spMasterCategoryGetAll",
                    commandType: CommandType.StoredProcedure
                    );
            }
            return list;
        }


    }
}