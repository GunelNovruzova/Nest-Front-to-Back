using Microsoft.AspNetCore.Mvc;
using Nest.DAL;
using Nest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.Controllers
{
    public class ContactController : Controller
    {
        private readonly NestDB _context;
        public ContactController(NestDB context)
        {
            _context = context;
        }
        
       
        public IActionResult Index()
        {
            ContactVM contactVM = new ContactVM
            {
                Contact = _context.Contacts.FirstOrDefault(),
                Offices=_context.Offices.ToList(),
                Form=_context.Forms.FirstOrDefault()           };
            return View(contactVM);
        }
    }
}
