using DI_Test_ASP.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace DI_Test_ASP.Controllers
{
    public class HomeController : Controller
    {
        IMessageSender _messageSender;
        IEmployeesService _employeesService;
        TimeService _timeService;

        public HomeController(IMessageSender messageSender, TimeService timeService, IEmployeesService employeesService)
        {
            _messageSender = messageSender;
            _timeService = timeService;
            _employeesService = employeesService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _timeService.GetTime() + " " + _messageSender.Send();

            return View();
        }

        public IActionResult AddEmployee()
        {
            int newId = _employeesService.GetEmployees().Count() + 1;

            Employee emp = new Employee { Name = "John", Surename = "Doe", Patronymic = "J", 
                Age = 36, Gender = "Мужской", Id = newId, Profession = "Control system engeneer" };

            _employeesService.AddEmployee(emp);

            return View(_employeesService.GetEmployees());
        }
    }
}
