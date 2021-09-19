using EduHome.DataAccessLayer;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private AppEduHomeDbContext _context { get; }
        public HomeController(AppEduHomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            EduHomeViewModel model = new EduHomeViewModel();
            model.Slides = _context.Slides.ToList();
;           return View(model);
        }   

    }
}
