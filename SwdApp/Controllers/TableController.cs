using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Table;
using SwdApp.Data.Implementations;

namespace SwdApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableService tableService;

        public TableController(ITableService tableService, string name)
        {
            this.tableService = tableService;
        }

        [HttpGet]
        public async Task<IEnumerable<TableDto>> GetTable()
        {
            var listTable = await tableService.GetAllTable();
            return listTable;
        }
    }
}