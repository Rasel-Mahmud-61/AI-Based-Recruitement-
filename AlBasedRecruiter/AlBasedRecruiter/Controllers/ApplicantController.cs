using AlBasedRecruiter.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

using NHibernate.Linq;

namespace AlBasedRecruiter.Controllers
{
    public class ApplicantController : Controller
    {

   

        [HttpGet]
        public IActionResult Index()
        {
            using (var session = NhibernateHelper.GetSession())
            {
                var applicants = session.Query<Applicant>()
                                    .Fetch(x => x.Recruiter)   // Assuming `Recruiter` is a navigation property
                                    .Fetch(x => x.JobPosition) // Assuming `JobPosition` is a navigation property
                                    .ToList();


                return View(applicants);
            }
        }
    }
}
