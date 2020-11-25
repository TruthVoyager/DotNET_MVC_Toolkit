using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TidyData.Services;

namespace Tidey.web.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData db;

        public HomeController()
        {
            db = new InMemoryRestData();
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
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
    }
}