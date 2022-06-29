using ASP_Practise.DAL;
using ASP_Practise.Models;
using ASP_Practise.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Practise.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _context.Sliders.ToList();
            homeVM.NoticeLefts = _context.NoticeLefts.ToList();
            homeVM.NoticeRights = _context.NoticeRights.ToList();

            return View(homeVM);
        }
    }
}
