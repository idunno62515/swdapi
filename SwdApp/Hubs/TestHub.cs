using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwdApp.Hubs
{
    public class TestHub : Hub
    {
        public async Task MsgFromServer(int id)
        {
            await Clients.All.SendAsync("UpdateTableStatus", id);
        }
    }
}
