using Dapper;
using SwdApp.Data.Dtos.Product;
using SwdApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SwdApp.Data.Implementation
{
    public class ProductService : IProductService
    {
        private readonly string connectionString;

        public ProductService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<IEnumerable<ProductDto>> GetProductByCate(int cateId)
        {
            IEnumerable<ProductDto> list = null;
            using (var con = new SqlConnection(connectionString))
            {
                list = await con.QueryAsync<ProductDto>(
                    "spProductGetByCate",
                    new { CateId = cateId },
                    commandType: CommandType.StoredProcedure
                    );

            }
            return list;
        }

        public Task<IEnumerable<ProductDto>> GetProductById(int proId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> getProductByname(string name = "")
        {
            IEnumerable<ProductDto> list = null;

            using (var con = new SqlConnection(connectionString))
            {
                list = await con.QueryAsync<ProductDto>(
                    "spProductGetByName",
                    new { Name = name },
                    commandType: CommandType.StoredProcedure
                    );

            }
            return list;
        }
    }
}
