using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MediaFlowServer.Hubs
{
    public class MediaFlowHub : Hub
    {
        public async Task Send(string user, string message)
        {
            await Clients.User(user).SendAsync("ReceiveMessage", user, message);
        }
    }
}