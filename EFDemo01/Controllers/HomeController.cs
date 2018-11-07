using EFDemo01.DataAccess;
using EFDemo01.Models;
using System.Linq;
using System.Web.Mvc;

namespace EFDemo01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult ExampleForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExampleForm(Event @event)
        {
            //event is a reserved keyword, so we have to prefix an '@' to use it

            using (var dbContext = new EventsDbContext())
            {
                //add to the in memory collection
                dbContext.Events.Add(@event);

                //persist these data changes to the db
                dbContext.SaveChanges();

                //on successful saving of data, go to a 
                //different ACTION METHOD to start a new process
                return RedirectToAction("ExampleList");
            }
        }

        public ActionResult ExampleList()
        {
            using (var dbContext = new EventsDbContext())
            {
                var eventList = dbContext.Events.ToList();

                return View(eventList);
            }
        }
    }
}