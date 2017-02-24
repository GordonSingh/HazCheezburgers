using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SRChat.Startup))]

namespace SRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //insert configurations for the connect or hub wire ups
            app.MapSignalR();
        }
    }
}
