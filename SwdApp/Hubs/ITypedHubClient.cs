using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwdApp.Hubs
{
    public interface ITypedHubClient
    {
        Task BroadcastMessage(string name, int id, int status);
    }
}
