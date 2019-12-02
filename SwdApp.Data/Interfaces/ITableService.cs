using SwdApp.Data.Dtos.Table;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwdApp.Data.Implementations
{
    public interface ITableService
    {
        Task<IEnumerable<TableDto>> GetAllTable();
    }
}
