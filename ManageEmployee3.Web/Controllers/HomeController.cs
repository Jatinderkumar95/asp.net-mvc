using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageEmployee3.Web.Controllers
{
    public class HomeController : Controller
    {
        ManageEmployeeDbContext _context = new ManageEmployeeDbContext();
        public ActionResult Index()
        {
            var departments = _context.Departments.ToList();
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
    }
}