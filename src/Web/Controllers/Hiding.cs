using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class Hiding : Controller
    {
        public IActionResult ShowInfo()
        {
            return Content("Security Maintainence");
        }

        public IActionResult ShowJSON()
        {
            return Json(new
            {
                name = "My Data is Protected",
                author = "Haritha Atmakuri"
            });
        }
        public IActionResult ShowHTML(){
            var data="<!DOCTYPE HTML><HTML><body>My app is about securing your data"+"<br> 1)If you believe us please enter your information."+"<br>"+
            "2) If you don't belive our app then no need to enter your information."+"<br></body></HTML>";  
            return Content(data,"text/html");
        }
        public IActionResult SecurityApp(){
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
