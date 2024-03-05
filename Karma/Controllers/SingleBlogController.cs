using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class SingleBlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
