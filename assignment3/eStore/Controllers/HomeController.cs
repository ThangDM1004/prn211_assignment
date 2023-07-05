
using BusinessObjects;
using eStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace eStore.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		ICustomerRepository cus  = new CustomerRepository();
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Login()
		{
			return View();
		}
		public ActionResult LoginCheck(string email, string password)
		{
			IConfiguration builder = new ConfigurationBuilder()
			   .SetBasePath(Directory.GetCurrentDirectory())
			   .AddJsonFile("appsettings.json", true, true).Build();
			var email_ = builder["AdminAccount:AdminEmail"];
			var pass = builder["AdminAccount:AdminPass"];
			if (email_ == email && pass == password)
			{
				HttpContext.Session.SetString("role", "Admin");
				return RedirectToAction("Index");
			}else if (email_ == email && pass != password)
			{
				return RedirectToAction("Login");
			}
			else
			{
				Customer customer = cus.getMemberByEmail(email);
				if(customer == null)
				{
					
				}else if (customer.Password != password)
				{
					return RedirectToAction("Login");
				}
				else
				{
					if(customer.Password == password)
					{
                        HttpContext.Session.SetString("id", customer.CustomerId.ToString());
                        HttpContext.Session.SetString("role", customer.CustomerName);
                        return RedirectToAction("Index");
                    }
				}
			}
			return View();
		}
		public ActionResult Logout()
		{
			HttpContext.Session.Clear();
			return RedirectToAction("Login");
		}
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
