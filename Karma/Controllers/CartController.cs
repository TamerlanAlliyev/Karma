﻿using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
