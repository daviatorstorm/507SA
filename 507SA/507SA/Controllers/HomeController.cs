using DAL.EF;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _507SA.Controllers
{
    public class HomeController : Controller
    {
		_507SAContext db = new _507SAContext();
		// GET: Home
		public ActionResult Index()
        {
			IEnumerable<User> users = db.User;
			ViewBag.Users = users;
			return View();
        }
    }
}