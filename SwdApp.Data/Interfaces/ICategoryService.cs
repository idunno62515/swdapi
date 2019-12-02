using SwdApp.Data.Dtos.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwdApp.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCate();
        Task<IEnumerable<MasterCategoryDto>> GetAllMasterCate();
    }
}
