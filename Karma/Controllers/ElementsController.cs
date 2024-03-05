using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class ElementsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
