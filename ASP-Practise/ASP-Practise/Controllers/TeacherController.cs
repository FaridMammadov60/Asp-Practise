using Microsoft.AspNetCore.Mvc;

namespace ASP_Practise.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
