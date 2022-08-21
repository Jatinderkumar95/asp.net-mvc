using ManageEmployee5.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageEmployee5.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> Employees = new List<Employee>();
        public EmployeeController()
        {
            Employees = new List<Employee>
            {
                new Employee
                {
                    Email = "a@a.com",
                    Id  =1,
                    Name = "A"
                },
                 new Employee
                {
                    Email = "b@b.com",
                    Id  =2,
                    Name = "B"
                }
            };
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(Employees);
        }
        //public ActionResult GetById(int id)
        //{
        //    return View(Employees.First(a=>a.Id == id));
        //}
        public ActionResult GetById(string id)
        {
            return View(Employees.First(a => a.Id == Convert.ToInt32(id)));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Create()
        //{
        //    return View();
        //}
    }
}