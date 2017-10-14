using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspproj4.Controllers
{
    public class BootstrpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult bootstr()
        {
            return View();
        }

    }
}