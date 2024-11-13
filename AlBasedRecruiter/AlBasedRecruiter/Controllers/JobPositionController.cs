using AlBasedRecruiter.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

using NHibernate.Linq;

namespace AlBasedRecruiter.Controllers
{
    public class JobPositionController : Controller
    {
       
        // Constructor to initialize session

        [HttpGet]
        public IActionResult Index()
        {
            using (var session = NhibernateHelper.GetSession())
            {
                // Use CreateCriteria instead of LINQ
                var jobpositions = session.Query<JobPosition>().ToList();
                return View(jobpositions);
            }
        }
    }
}
