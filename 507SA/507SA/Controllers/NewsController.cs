using _507SA.ModelsVM;
using AutoMapper;
using DAL.Models;
using DAL.Repository.NoweltyRepositoty;
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

		public NewsController(
			INoweltyRepository noweltyRepository
		)
		{
			_noweltyRepository = noweltyRepository;
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
	}
}