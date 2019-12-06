using SwdApp.Data.Dtos.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwdApp.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetCatesWithProductsByMasterCateId(int masterCateId);
        Task<IEnumerable<MasterCategoryDto>> GetAllMasterCate();

        

    }
}
