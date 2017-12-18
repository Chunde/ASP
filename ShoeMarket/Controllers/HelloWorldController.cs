﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeMarket.Controllers
{
    public class HelloWorldController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "Hello " + name;
            ViewData["numTime"] = numTimes;

            return View();
        }
    }
}
;