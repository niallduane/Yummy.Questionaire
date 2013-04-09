using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCQuestionaire.Extensions;

namespace MVCQuestionaire.Controllers
{
    public class HomeController : Controller
    {
        private Models.IQuestionaireService service;
        
        public HomeController() 
        {
            service = new Models.QuestionaireService();
        }

        public HomeController(Models.IQuestionaireService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Index View
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Index(int id = 0)
        {
            ViewData.Add("Questions", service.GetQuestions());
            return View(service.GetUser(id));
        }

        /// <summary>
        /// Processes the questionaire form submission by the user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(Models.User user)
        {
            ModelState.AddModelErrors(service.ProcessTest(user, new FormCollection(Request.Form)));

            if (ModelState.IsValid)
                return RedirectToAction("Completed", new { id = user.UserId });

            ViewData.Add("Questions", service.GetQuestions());
            return View(user);
        }

        /// <summary>
        /// Completed View
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Completed(int id)
        {
            return View(service.GetUser(id));
        }
    }
}
