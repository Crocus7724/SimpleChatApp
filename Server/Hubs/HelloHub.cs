using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Hubs;

namespace Server.Hubs
{
	[HubName("hello")]
	public class HelloHub:Hub
	{
		public void Hello(string name)
		{
			Clients.All.helloWorld($"{name}: Hello World!!");
		}
	}
}