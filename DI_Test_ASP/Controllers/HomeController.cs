using DI_Test_ASP.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Test_ASP.Controllers
{
    public class HomeController : Controller
    {
        IMessageSender _messageSender;
        TimeService _timeService;

        public HomeController(IMessageSender messageSender, TimeService timeService)
        {
            _messageSender = messageSender;
            _timeService = timeService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _timeService.GetTime() + " " + _messageSender.Send();

            return View();
        }
    }
}
