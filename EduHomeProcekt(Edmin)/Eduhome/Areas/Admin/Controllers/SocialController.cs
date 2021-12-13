using Eduhome.EduHomeDbContext;
using Eduhome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {
        private readonly EduHomeDb _context;
        public SocialController(EduHomeDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Social> model = _context.Socials.ToList();
            return View(model);
        }
    }
}
