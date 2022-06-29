using Microsoft.AspNetCore.Mvc;

namespace ASP_Practise.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
