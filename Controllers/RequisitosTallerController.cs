using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROYECTO_VISION_USMP.Models;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Controllers
{
    public class RequisitosTallerController : Controller
    {
        private readonly MvcContext _context;

        public RequisitosTallerController(MvcContext context)
        {
            _context = context;
        }

        // GET: RequisitosTaller
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.RequisitosTaller.Include(r => r.CodigoExpositor).Include(r => r.CodigoTaller);
            return View(await mvcContext.ToListAsync());
        }

        
    }
}
