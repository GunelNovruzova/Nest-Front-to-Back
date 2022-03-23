using Microsoft.AspNetCore.Mvc;
using Nest.DAL;
using Nest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.Controllers
{
    public class ProductController : Controller
    {
        private readonly NestDB _context;
        public ProductController(NestDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ProductVM  productVM= new ProductVM
            {
                Product=_context.Products.FirstOrDefault(),
                Categories=_context.Categories.ToList(),
                NewProducts=_context.NewProducts.ToList(),
                Relateds=_context.Relateds.ToList()
                
            };
           
            return View(productVM);
        }
    }
}
