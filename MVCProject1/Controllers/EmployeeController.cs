using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject1.Models;


namespace MVCProject1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeInfo()
        {
            Employee employee=new Employee()
            {
                EmployeeId = 1001,
                EmployeeName = "Abhinav",
                EmployeeLocation = "Hyderabad"
            };
            return View(employee);
        }
    }
}