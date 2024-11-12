using AlBasedRecruiter.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

using NHibernate.Linq;

namespace AlBasedRecruiter.Controllers
{
    public class RecruiterController : Controller
    {
        private NHibernate.ISession session;

        // Constructor to initialize session

        [HttpGet]
        public IActionResult Index()
        {
            using (var session = NhibernateHelper.GetSession())
            {
                // Use CreateCriteria instead of LINQ
                var recruiter= session.Query<Recruiter>().ToList();
                return View(recruiter);
            }
        }
    }
}
