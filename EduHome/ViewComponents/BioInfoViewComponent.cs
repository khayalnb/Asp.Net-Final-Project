using EduHome.DataAccessLayer;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class BioInfoViewComponent:ViewComponent
    {
        public AppEduHomeDbContext _context { get;}
        public BioInfoViewComponent(AppEduHomeDbContext context)
        {
            _context = context;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _context.bioInformation.FirstOrDefaultAsync();
            return View(model);
        }

    }
}
