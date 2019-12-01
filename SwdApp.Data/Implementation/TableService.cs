using Dapper;
using SwdApp.Data.Dtos;
using SwdApp.Data.Implementations;
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

        public async Task<IEnumerable<Table>> GetAllTable()
        {
            IEnumerable<Table> tables = null;
            using(var con = new SqlConnection(_connectionString))
            {
                tables =await con.QueryAsync<Table>("spGetAllTable", commandType: CommandType.StoredProcedure);
            }
            return tables;
        }
    }
}
