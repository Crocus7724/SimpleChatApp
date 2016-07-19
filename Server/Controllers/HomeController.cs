using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
	public class HomeController:Controller
	{
		public IActionResult Hello() => View();
	}
}