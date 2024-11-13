using AlBasedRecruiter.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate.Linq;

namespace AlBasedRecruiter.Controllers
{
    public class InterviewController : Controller
    {
        public IActionResult InterviewIndex()
        {
            using (var session = NhibernateHelper.GetSession())
            {
                var applicants = session.Query<Interview>()
                                        .Fetch(x => x.Recruiter)
                                        .Fetch(x => x.Applicant)
                                        .Fetch(x => x.JobPosition)
                                        .Take(10)
                                        .ToList();

                return View(applicants);
            }
        }
    }
}
