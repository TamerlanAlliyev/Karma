using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
