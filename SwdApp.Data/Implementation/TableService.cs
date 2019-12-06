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


        public async Task<IEnumerable<ListTableDisplayByFloorDto>> GetListTableDisplayByFloor()
        {
            IEnumerable<ListTableDisplayByFloorDto> list = null;
            var floorDic = new Dictionary<int, ListTableDisplayByFloorDto>();
            using (var con = new SqlConnection(_connectionString))
            {
                list = await con.QueryAsync<ListTableDisplayByFloorDto, TableDto, ListTableDisplayByFloorDto>(
                    "spTableGetListByFloor",
                    (tableDisplayByFloor, table) =>
                    {
                        ListTableDisplayByFloorDto listTableEntry = null;
                        if (!floorDic.TryGetValue(tableDisplayByFloor.FloorNum, out listTableEntry))
                        {
                            listTableEntry = tableDisplayByFloor;
                            listTableEntry.Tables = new List<TableDto>();
                            floorDic.Add(listTableEntry.FloorNum, listTableEntry);
                        }

                        listTableEntry.Tables.Add(table);
                        return listTableEntry;
                    },
                     splitOn: "Id",
                     commandType: CommandType.StoredProcedure);
            }
            return floorDic.Values;
        }

        public async Task<IEnumerable<TableDto>> GetAllTable()
        {
            IEnumerable<TableDto> tables = null;
            using (var con = new SqlConnection(_connectionString))
            {
                tables = await con.QueryAsync<TableDto>(
                    "spTableGetAll",
                    commandType: CommandType.StoredProcedure
                    );
            }
            return tables;
        }
    }
}
