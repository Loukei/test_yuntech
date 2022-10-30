using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcSchool.Controllers{
    [Route("Student/[Action]")]
    public class StudentController: Controller
    {
        /// ./School/Student/List
        public IActionResult List()
        {
            /// get all list of students
            ViewData["Message"] = "Show all Students";
            // ViewData[""] = 3;
            return View();
        }
    }
}