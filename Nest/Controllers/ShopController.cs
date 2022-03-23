using Microsoft.AspNetCore.Mvc;
using Nest.DAL;
using Nest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.Controllers
{
    public class ShopController : Controller
    {
        private readonly NestDB _context;
        public ShopController(NestDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ShopVM shopVM = new ShopVM
            {
                Shops=_context.Shops.ToList(),
                Deals=_context.Deals.ToList()
            };
        
            return View(shopVM);
        }
    }
}
