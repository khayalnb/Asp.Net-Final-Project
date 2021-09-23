using EduHome.DataAccessLayer;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppEduHomeDbContext _context;
        public ContactController(AppEduHomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> SendForm(ContactMessage contactMessage)
        {
            ContactMessage message = new ContactMessage
            {
                Name=contactMessage.Name,
                Email = contactMessage.Email,
                Subject=contactMessage.Subject,
                Message=contactMessage.Message

            };

            _context.ContactMessages.Add(contactMessage);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
