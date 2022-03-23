using Microsoft.AspNetCore.Mvc;
using Nest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
