using _507SA.ModelsVM;
using AutoMapper;
using DAL.Models;
using DAL.Repository.FileRepository;
using DAL.Repository.NoweltyRepositoty;
using DAL.Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _507SA.Controllers
{
    public class NewsController : Controller
    {
		// GET: News
		private readonly INoweltyRepository _noweltyRepository;
		private readonly IUserRepository _userRepository;

		public NewsController(
			INoweltyRepository noweltyRepository, IUserRepository userRepository
		)
		{
			_noweltyRepository = noweltyRepository;
			_userRepository = userRepository;
		}
		public ActionResult News()
        {
			NewsListVM newsListsVM = new NewsListVM();
			IList<Nowelty> news = _noweltyRepository.GetAll().ToList();
			newsListsVM.AllNews = Mapper.Map<IList<Nowelty>, IList<NoweltyVM>>(news);
			return View(newsListsVM);
		}
		public ActionResult NewsDetail(int? id)
		{
			Nowelty news= _noweltyRepository.Get(id.GetValueOrDefault());
			NoweltyVM newsVM = new NoweltyVM();
			newsVM= Mapper.Map<Nowelty, NoweltyVM>(news);
			return View(newsVM);
		}
		[HttpPost]
		public ActionResult NewsDetail(NoweltyVM noweltyVM)
		{
			Nowelty nowelty = _noweltyRepository.Get(noweltyVM.Id);
			User user = _userRepository.GetByEmail(User.Identity.Name);
			nowelty.Comment.Add(new Comment() { Text = noweltyVM.CommentText, NoweltyId = noweltyVM.Id, UserId = user.Id, DateOfComment=DateTime.Now});
			_noweltyRepository.UnitOfWork.SaveChanges();
			Nowelty newNowelty= _noweltyRepository.Get(noweltyVM.Id);
			NoweltyVM newNoweltyVM = Mapper.Map<Nowelty, NoweltyVM>(nowelty);

			/*if(newNoweltyVM.Comment[newNoweltyVM.Comment.Count-1].User== null)
			{
				newNoweltyVM.Comment[newNoweltyVM.Comment.Count - 1].User = user;
			} */

			return RedirectToAction( "NewsDetail",newNoweltyVM);
		}
	}
}