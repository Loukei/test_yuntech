using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcSchool.Controllers{
    [Route("Student/[Action]")]
    public class StudentController: Controller
    {
        /// ./School/Student/List
        public IActionResult List()
        {
            ///TODO: get all list of students
            ViewData["Message"] = "Show all Students";
            // ViewData[""] = 3;
            return View();
        }
        /// get ./School/Student/<int: sid>/class/list
        /// 列出所有選課資料

        /// get ./School/Student/<int: sid>/edit
        /// 顯示學生的資料編輯頁面

        /// get ./School/Student/<int: sid>/delete
        /// 顯示刪除學生資料的對話框

        /// post ./School/Student/<int: sid>/delete
        /// 刪除對應學生資料
    }
}