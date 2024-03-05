using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
