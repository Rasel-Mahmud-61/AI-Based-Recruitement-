using AlBasedRecruiter.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate.Linq;

namespace AlBasedRecruiter.Controllers
{
    public class BiasController : Controller
    {
        public IActionResult BiasIndex()
        {
            using (var session = NhibernateHelper.GetSession())
            {
                var applicants = session.Query<Bias>()
                                    .Fetch(x => x.Interview)   // Assuming `Recruiter` is a navigation property
                                    .Fetch(x => x.JobPosition)
                                    .Fetch(x => x.Applicant)
                                    .Fetch(x => x.AIEvaluation)
                                     .Take(10)
                                    .ToList();


                return View(applicants);
            }
        }
    }
}
