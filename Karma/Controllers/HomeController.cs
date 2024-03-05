using Karma.Data;
using Karma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Karma.Controllers
{
    public class HomeController : Controller
    {
        public readonly KarmaContext _karmaContext;

		public HomeController(KarmaContext karmaContext)
		{
			_karmaContext = karmaContext;
		}

		public async Task<IActionResult> Index()
		{
            return View(await _karmaContext.Sliders.ToListAsync());
        }
    }
}
