using SurveyFormsWeb.Models;
using SurveyFormsWeb.Repositories;
using SurveyFormsWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyFormsWeb.Controllers
{
    public class SurveyController : Controller
    {
        private SurveyRepository _surveyRepository;

        public SurveyController()
        {
            _surveyRepository = new SurveyRepository();
        }

        // GET: Survey
        [HttpGet]
        public ActionResult Index()
        {
            List<string> surveys = _surveyRepository.List();

            return View(new SurveyListViewModel() { Surveys = surveys });
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Survey survey)
        {
            survey.Id = Guid.NewGuid();
            _surveyRepository.Add(survey);

            return Redirect("Index");
        }
    }
}