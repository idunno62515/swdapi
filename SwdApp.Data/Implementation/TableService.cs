using Dapper;
using SwdApp.Data.Dtos;
using SwdApp.Data.Dtos.Table;
using SwdApp.Data.Implementations;
using SwdApp.Data.Utilities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SwdApp.Data.Interfaces
{
    public class TableService : ITableService
    {
        private readonly string _connectionString;

        public TableService(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public async Task<IEnumerable<TableDto>> GetAllTable()
        {
            IEnumerable<TableDto> tables = null;
            using(var con = new SqlConnection(_connectionString))
            {
                tables =await con.QueryAsync<TableDto>(
                    SroteProcedureName.spGetAllTable, 
                    commandType: CommandType.StoredProcedure
                    );
            }
            return tables;
        }
    }
}
