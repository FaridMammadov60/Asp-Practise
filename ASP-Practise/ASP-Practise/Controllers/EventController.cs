using Microsoft.AspNetCore.Mvc;

namespace ASP_Practise.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
