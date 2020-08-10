using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
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


        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        /*
        *numTimes parameter defaults to 1 if no value is passed for that parameter.
        *Uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript).
        *Uses Interpolated Strings in $"Hello {name}, NumTimes is: {numTimes}".   
        */

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
