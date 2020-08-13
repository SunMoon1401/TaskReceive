using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskReceiverMVC.Models;

namespace TaskReceiverMVC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		[HttpGet]
		public ActionResult AddNewDownLine()
		{
			return View();
		}
		[HttpPost]
		public ActionResult AddNewDownLine(string PassWord, string FirstName, string LastName, double Commission,
			int TotalCredit, int MaxCreditLimit, int MaxPerBet, int MaxBetMatch, int AccountNumber)
		{
			return View();
		}
	}
}