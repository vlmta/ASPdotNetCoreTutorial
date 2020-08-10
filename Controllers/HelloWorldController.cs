using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPdotNetCoreTutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        /*
          Index is the default method that will be called on a controller 
        if a method name isn't explicitly specified.
        format:
            [Controller]/[ActionName]/[Parameters]
         */
        public IActionResult Index()
        {
            return View();
        }
    }
}
