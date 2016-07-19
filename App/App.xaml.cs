using System;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;
using Xamarin.Forms;

namespace App
{
	public partial class App : Application
	{
		private HubConnection conn;
		private IHubProxy proxy;

		public App()
		{
			InitializeComponent();

			var label = new Label();
			var button = new Button()
			{
				Text = "送信",
			};

			conn = new HubConnection("http://localhost:5000");
			proxy = conn.CreateHubProxy("hello");

			proxy.On<string>("helloWorld", x => { label.Text = x; });
			conn.Start();

			button.Clicked += OnClick;

			var stack = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
			};
			stack.Children.Add(label);
			stack.Children.Add(button);

			MainPage = new ContentPage()
			{
				Content = stack,
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}

		private void OnClick(object sender, EventArgs e)
		{
			proxy.Invoke("Hello", "App");
		}
	}
}

