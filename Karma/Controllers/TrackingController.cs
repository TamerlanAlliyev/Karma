using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class TrackingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
