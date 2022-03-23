using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest.DAL;
using Nest.Models;
using Nest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.Controllers
{
    public class AboutController : Controller
    {
        private readonly NestDB _context;

        public AboutController(NestDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //About about = _context.Abouts.Include(a=> a.AboutImages).FirstOrDefault();
            //if (about == null) return BadRequest();

            AboutVM aboutVM = new AboutVM
            {
                About = _context.Abouts.Include(a => a.AboutImages).FirstOrDefault(),
                Providers = _context.Providers.ToList(),
                Performances = _context.Performances.FirstOrDefault(),
                Histories=_context.Histories.ToList(),
                TeamInfos=_context.TeamInfos.FirstOrDefault(),
                TeamMembers=_context.TeamMembers.ToList()
                
            };
            return View(aboutVM);
        }
    }
}
