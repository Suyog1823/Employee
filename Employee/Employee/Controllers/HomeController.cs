using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employee.Models;
using Employee.Views.RequestController;

namespace Employee.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDBContext _employee;
        public HomeController(EmployeeDBContext data)
        {
            _employee = data;
        }
        public IActionResult Index()
        {
            return View("HomePage");
        }

        public JsonResult GetEmployeeDetails()
        {
            var getTheEmployees = _employee.EmployeeDetails.ToList();
            return Json(getTheEmployees);
        }

        public async Task<JsonResult> GetEmployeeDetailsByIdAsync(int id)
        {
            var getTheEmployee = await _employee.EmployeeDetails.FindAsync(id);
            return Json(getTheEmployee);
        }

        [HttpPost]
        public JsonResult PostEmployee([FromBody]EmployeeDetailsRequest value)
        {
            EmployeeDetails obj = new EmployeeDetails();
            obj.EmployeeName = value.EmployeeName;
            obj.Age = value.Age;
            obj.Designation = value.Designation;
            obj.WorkedYears = value.WorkedYears;

            _employee.EmployeeDetails.Add(obj);
            _employee.SaveChanges();
            return Json(value);
        }
        /*public JsonResult getData(string value)
        {
            var getTheData =  _employee.EmployeeDetails.Where(obj => obj.Designation.Contains(value));
            return Json(getTheData);
        }*/
    }
}

