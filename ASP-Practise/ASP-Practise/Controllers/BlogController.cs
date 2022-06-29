using Microsoft.AspNetCore.Mvc;

namespace ASP_Practise.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
