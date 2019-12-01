using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwdApp.Data.Dtos;
using SwdApp.Data.Implementations;
using SwdApp.ViewModels;

namespace SwdApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableService tableService;

        public TableController(ITableService tableService)
        {
            this.tableService = tableService;
        }

        [HttpGet]
        public async Task<IEnumerable<TableViewModel>> GetTable()
        {
            var res = await tableService.GetAllTable();

            return res.Adapt<IEnumerable<TableViewModel>>();
        }
    }
}