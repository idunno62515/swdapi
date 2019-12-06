using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Table;
using SwdApp.Data.Implementations;

namespace SwdApp.Controllers
{
    [Route("api/tables")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableService tableService;

        public TableController(ITableService tableService)
        {
            this.tableService = tableService;
        }

        //[HttpGet]
        //public async Task<IEnumerable<TableDto>> GetTable()
        //{
        //    var listTable = await tableService.GetAllTable();
        //    return listTable;
        //}

        [HttpGet]
        public async Task<IEnumerable<ListTableDisplayByFloorDto>> GetListTableDisplayByFloor()
        {
            var listTableDisplay = await tableService.GetListTableDisplayByFloor();
            return listTableDisplay;
        }
    }
}