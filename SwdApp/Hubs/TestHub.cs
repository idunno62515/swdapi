using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwdApp.Hubs
{
    public class TestHub : Hub
    {
        public async Task Send(int id, int status)
        {
            await Clients.All.SendAsync("UpdateTable", id, status);
        }
    }
}
