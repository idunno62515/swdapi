using SwdApp.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwdApp.Data.Implementations
{
    public interface ITableService
    {
        Task<IEnumerable<Table>> GetAllTable();
    }
}
