using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos.Table;
using SwdApp.Data.Implementations;

namespace SwdApp.Controllers
{
    [Route("api/tables")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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