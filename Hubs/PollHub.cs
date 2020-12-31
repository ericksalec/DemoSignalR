using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSignalR.Hubs
{
    public class PollHub : Hub
    {
        //realizar o envio das mensagens para todas as conexões.
        public async Task SendMessage(string user, string message, string myChannelId, string myChannelVal)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, myChannelId, myChannelVal).ConfigureAwait(false);
        }

        //realizar o envio das mensagens para um grupo definido de conexões.
        //public async Task SendMessageGroup(string user, string message, string myChannelId, string myChannelVal, string groupName)
        //{

        //    await Groups.AddToGroupAsync(Context.ConnectionId, "Grupo");

        //    await Clients.Group(groupName).SendAsync("ReceiveMessage", user, message, myChannelId, myChannelVal).ConfigureAwait(false);
        //}
    }
}

