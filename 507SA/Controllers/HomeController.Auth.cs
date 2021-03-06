﻿using _507SA.ModelsVM;
using _507SA.Session;
using AutoMapper;
using DAL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace _507SA.Controllers
{
	public partial class HomeController:Controller
	{

		[HttpGet]
		public ActionResult Index()
		{
			if (User.Identity.IsAuthenticated)
				if (User.IsInRole(Roles.User))
				{
					return RedirectToAction("News", "News");
				}		
			return View();
		}

		[HttpPost]
		public ActionResult Index(UserCredentialsVM userCredentialsVM)
		{
			User user = _userRepository.GetByCredentials(userCredentialsVM.Email, userCredentialsVM.Password);
			if (user == null)
			{
				ModelState.AddModelError("credentials", "Invalid username or password");
				return View();
			}
			SessionManager.CurentUserContext = Mapper.Map<User, UserContext>(user);
			List<Claim> claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.Name, user.Email));
			claims.Add(new Claim(ClaimTypes.Role, Roles.User));
			if (SessionManager.CurentUserContext.IsAdmin)
				claims.Add(new Claim(ClaimTypes.Role, Roles.Admin));

			var identity = new ClaimsIdentity(claims.ToArray<Claim>(), DefaultAuthenticationTypes.ApplicationCookie);
			HttpContext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties { IsPersistent = userCredentialsVM.RememberMe }, identity);
			return RedirectToAction("Index");
		}
		[Authorize]
		public ActionResult Logout()
		{
			HttpContext.GetOwinContext().Authentication.SignOut();
			return RedirectToAction("Index");
		}
		[HttpPost]
		public ActionResult Register(UserVM userVM)
		{
			if (ValidateRegisterData(userVM))
			{
				User user = new User();
				user.FirstName = userVM.FirstName;
				user.LastName = userVM.LastName;
				user.Password = userVM.Password;
				user.Phone = userVM.Phone;
				user.Email = userVM.Email;
				_userRepository.Add(user);
				_userRepository.UnitOfWork.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				return View();
			}

		}
		private bool ValidateRegisterData(UserVM userVM)
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

			if (string.IsNullOrWhiteSpace(userVM.Password)
				|| string.IsNullOrWhiteSpace(userVM.ConfirmPassword)
				|| userVM.Password != userVM.ConfirmPassword)
			{
				isValid = false;
			}
			return isValid;
		}
	}
}