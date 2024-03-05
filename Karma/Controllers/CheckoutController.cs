using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class CheckoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
