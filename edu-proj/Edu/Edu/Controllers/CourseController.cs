using Microsoft.AspNetCore.Mvc;

namespace Edu.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
