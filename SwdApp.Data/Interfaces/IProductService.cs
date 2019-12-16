using SwdApp.Data.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwdApp.Data.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProductByCate(int cateId);
        Task<IEnumerable<ProductDto>> GetProductById(int proId);
        Task<IEnumerable<ProductDto>> getProductByname(string name);
    }
}
