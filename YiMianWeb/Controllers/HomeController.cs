using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiMianWeb.Models;

namespace YiMianWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Submit(HomeModel model)
        {
            using (AnswerContext db = new AnswerContext())
            {
                AnswerEntity answer = new AnswerEntity()
                {
                    Content = model.Content,
                    UserId = model.UserId,
                    ProblemId = model.ProblemId,
                    AnswerTime = DateTime.Now,
                    CreateTime = DateTime.Now,
                    ChangeTime = DateTime.Now

                };
                db.Answers.Add(answer);
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
        public ActionResult Index(int problemId = 1)
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            using (ProblemContext db = new ProblemContext())
            {
                ProblemEntity problem = db.Problems.FirstOrDefault(p => p.ProblemId == problemId);

                ViewBag.Problem = problem;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
