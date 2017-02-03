using _507SA.ModelsVM;
using AutoMapper;
using DAL.Models;
using DAL.Repository.SubjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _507SA.Controllers
{
    public class SubjectController : Controller
    {
		
			// GET: News
			private readonly ISubjectRepository _subjectRepository;

			public SubjectController(
				ISubjectRepository subjectRepository
			)
			{
				_subjectRepository = subjectRepository;
			}
			// GET: Subject
			public ActionResult Subject()
        {
			IList<Subject> subjects = _subjectRepository.GetAll().ToList();
			IList<SubjectVM>subjectsVM = Mapper.Map<IList<Subject>, IList<SubjectVM>>(subjects);
			return View(subjectsVM);
        }
    }
}