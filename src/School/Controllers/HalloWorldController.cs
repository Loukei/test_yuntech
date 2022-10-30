using Microsoft.AspNetCore.Mvc;
/// To return a html string
using System.Text.Encodings.Web;

/// unknowned: use namespace to seperate different module, like apps in django
/// {MvcSchool} module name
/// {.Controllers} as controller in module
namespace MvcSchool.Controllers
{
    public class HalloWorldController: Controller
    {
        /// GET /HalloWorld/
        public IActionResult Index(){
            ///
            return View();
        }

        ///ex:  GET /HalloWorld/Welcome?name=peter&numtimes=4
        public IActionResult Welcome(string name = "", int numtimes = 1){
            ViewData["Message"] = "Hello, " + name;
            ViewData["numtimes"] = numtimes;
            return View();
        }
    }
}
