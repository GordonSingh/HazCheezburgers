using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SRChat.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name,string message)
        {
            //broadcastMessage updates the clients
            Clients.All.broadcastMessage(name,message);
        }
    }
}