using Microsoft.AspNetCore.Mvc;
using Nest.DAL;
using Nest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.Controllers
{
    public class HomeController : Controller
    { 
        private readonly NestDB _context;

        public HomeController(NestDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Homes = _context.Homes.ToList(),
                DealsHomes=_context.DealsHomes.ToList()
            };
            return View(homeVM);
        }
    }
}
