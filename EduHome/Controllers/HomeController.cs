using EduHome.DataAccessLayer;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult>   Index()
        {
            EduHomeViewModel model = new EduHomeViewModel()
            {
                Slides = await _context.Slides.ToListAsync(),
                BioInformation = await _context.bioInformation.FirstOrDefaultAsync()
            }


;           return View(model);
        }   

    }
}
