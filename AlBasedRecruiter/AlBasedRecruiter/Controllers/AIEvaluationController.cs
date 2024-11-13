using AlBasedRecruiter.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

using NHibernate.Linq;

namespace AlBasedRecruiter.Controllers
{
    public class AIEvaluationController : Controller
    {
        [HttpGet]
        public IActionResult AI()
        {
            using (var session = NhibernateHelper.GetSession())
            {
                var evaluations= session.Query<AIEvaluation>()
                                    .Fetch(x => x.Applicant)   
                                    .Fetch(x => x.JobPosition)
                                     .Take(10)
                                    .ToList();


                return View(evaluations);
            }
        }
    }
}
