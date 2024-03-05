using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class SingleProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
