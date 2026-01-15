using Microsoft.AspNetCore.Mvc;

namespace mvc_demo.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
