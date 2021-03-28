using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorRealTimeSignalR.Server.Hubs
{
    public class DashboardHub:Hub
    {
        public async Task DashboardDragAndDrop(string id, int row, int column)
        {
            await Clients.All.SendAsync("LayoutChange", id, row, column);
        }
    }
}
