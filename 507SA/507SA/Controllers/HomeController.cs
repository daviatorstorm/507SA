using _507SA.ModelsVM;
using AutoMapper;
using DAL.EF;
using DAL.Models;
using DAL.Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _507SA.Controllers
{
	public class HomeController : Controller
    {
		// GET: Home
		private readonly IUserRepository _userRepository;
		public HomeController(
			IUserRepository userRepository
		)
		{
			_userRepository = userRepository;
		}
		[HttpGet]
		public ActionResult Index()
        {
			return View();
        }
		public ActionResult Register()
		{
			return View();
		}
		public ActionResult About()
		{
			UsersListsVM usersListsVM = new UsersListsVM();
			IList<User> users = _userRepository.GetAll().ToList();
			usersListsVM.AllUsers= Mapper.Map<IList<User>, IList<UserVM>>(users);
			return View(usersListsVM);
		}
		public ActionResult Subject()
		{
			/*IEnumerable<Subject> subjects = db.Subject;
			ViewBag.Subjects= subjects;*/
			return View();
		}
	}
}