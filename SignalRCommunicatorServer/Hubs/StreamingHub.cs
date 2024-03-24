using Microsoft.AspNetCore.SignalR;

namespace SignalRCommunicatorServer.Hubs
{
	public class StreamingHub : Hub
	{
		public async Task BroadcastImage(byte[] imageBytes)
		{
			await Clients.Others.SendAsync("ReceiveImage", imageBytes);
		}

		public async Task BroadcastAudio(byte[] audioBytes)
		{
			await Clients.Others.SendAsync("ReceiveAudio", audioBytes);
		}
	}
}
