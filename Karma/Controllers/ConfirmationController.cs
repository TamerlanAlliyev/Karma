using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class ConfirmationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
