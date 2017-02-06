using _507SA.ModelsVM;
using _507SA.Session;
using AutoMapper;
using DAL.EF;
using DAL.Models;
using DAL.Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace _507SA.Controllers
{
	public partial class HomeController : Controller
    {
		// GET: Home
		private readonly IUserRepository _userRepository;
		public HomeController(
			IUserRepository userRepository
		)
		{
			_userRepository = userRepository;
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
		public ActionResult ChangeProfile()
		{
			UserVM userVM = new UserVM();
			User user = _userRepository.GetByEmail(User.Identity.Name);
			userVM = Mapper.Map<User,UserVM>(user);
			userVM.Password = "";
			return View(userVM);
		}
		[HttpPost]
		public ActionResult ChangeProfile(UserVM userVM)
		{
			User user = _userRepository.Get(userVM.Id);
			if(ValidateChangeData(userVM, user))
			{
				user.FirstName = userVM.FirstName;
				user.LastName = userVM.LastName;
				user.Email = userVM.Email;
				user.Phone = userVM.Phone;
				if ((userVM.Password == user.Password) && (userVM.NewPassword == userVM.ConfirmNewPassword))
				{
					user.Password = userVM.NewPassword;
				}
				user.Info = userVM.Info;
				_userRepository.UnitOfWork.SaveChanges();
			}
			else
			{
				return View(userVM);
			}
			return View(userVM);
		}
		private bool ValidateChangeData(UserVM userVM, User userBase)
		{
			bool isValid = true;

			try
			{
				MailAddress email = new MailAddress(userVM.Email);
			}
			catch (Exception)
			{
				isValid = false;
			}
			if (
				(string.IsNullOrWhiteSpace(userVM.Password)
					&& string.IsNullOrWhiteSpace(userVM.NewPassword)
					&& string.IsNullOrWhiteSpace(userVM.ConfirmNewPassword)
				)
				|| (!string.IsNullOrWhiteSpace(userVM.Password)
					&& userVM.Password == userBase.Password
					&& userVM.NewPassword == userVM.ConfirmNewPassword
				)
			)
			{
				isValid = true;
			}
			else
				isValid = false;
			return isValid;
		}

	}
}