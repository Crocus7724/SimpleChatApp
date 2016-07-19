using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Hubs;

namespace Server.Hubs
{
	[HubName("hello")]
	public class HelloHub:Hub
	{
		public void Chat(string name,string text)
		{
			Clients.All.Chat($"{name}: {text}");
		}

		public void Login(string name)
		{
			Clients.All.Chat($"{name}がログインしました。");
		}
	}
}