using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.Controllers
{
    public class UvIndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}