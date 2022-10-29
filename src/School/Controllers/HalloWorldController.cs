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

        /// GET /HalloWorld/Welcome
        public string Welcome(string name = "", int numtimes = 1){
            return HtmlEncoder.Default.Encode($"Hello {name}, welcome {numtimes}.");
        }
    }
}
