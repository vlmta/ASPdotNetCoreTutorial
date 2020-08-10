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
        public string Welcome(string name, int ID = 1)
        {
         /*
         * /helloworld/welcome/3?name=Tam
         * id that matched the URL template in the MapControllerRoute method.
         */
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
