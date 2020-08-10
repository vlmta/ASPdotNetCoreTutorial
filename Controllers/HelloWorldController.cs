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
        public string Index()
        {
            return "This is my default action method... ";
        }


        /*
         *numTimes parameter defaults to 1 if no value is passed for that parameter.
         *Uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript).
         *Uses Interpolated Strings in $"Hello {name}, NumTimes is: {numTimes}".   
         */

        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
