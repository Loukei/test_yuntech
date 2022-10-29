
``` c#
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
```

- 預設的Controller為何不用設定URL routing 規則
  - 函式名稱與對應的URL之間的關係
- 為何沒有判斷HTTP method

[第 2 部分，將控制器新增至 ASP.NET Core MVC 應用程式 | Microsoft Learn](https://learn.microsoft.com/zh-tw/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-6.0&tabs=visual-studio-code#add-a-controller)

```c#
public IActionResult Index(){
            return View();
        }
```

- `View()`這段程式碼做了什麼?
  - 他是如何取出`index.cshtml`的模板內容，如何找到對應的檔案位置與檔名
  - `IActionResult`是什麼?