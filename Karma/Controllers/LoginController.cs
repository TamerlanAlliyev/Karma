using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
