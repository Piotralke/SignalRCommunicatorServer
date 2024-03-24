using Microsoft.AspNetCore.SignalR;

namespace SignalRCommunicatorServer.Hubs
{
	public class MessagingHub : Hub
	{
		public async Task SendMessage(string user, string message)
		{
			await Clients.All.SendAsync("ReceiveMessage", user, message);
		}
	}
}
