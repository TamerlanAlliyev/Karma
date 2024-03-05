using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
