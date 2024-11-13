using AlBasedRecruiter.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate.Linq;

namespace AlBasedRecruiter.Controllers
{
    public class HiringController : Controller
    {
        public IActionResult Result()
        {
            using (var session = NhibernateHelper.GetSession())
            {
                var applicants = session.Query<HiringOffer>()
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
