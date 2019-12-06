using System;
using System.Collections.Generic;
using System.Text;

namespace SwdApp.Data.Dtos.Table
{
    public class ListTableDisplayByFloorDto
    {
        public int FloorNum { get; private set; }
        public List<TableDto> Tables { get; set; }

    }
}
