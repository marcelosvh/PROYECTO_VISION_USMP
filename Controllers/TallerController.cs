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
    public class TallerController : Controller
    {
        private readonly MvcContext _context;

        public TallerController(MvcContext context)
        {
            _context = context;
        }

        // GET: Taller
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.Taller.Include(t => t.CodigoAula).Include(t => t.CodigoCarrera).Include(t => t.CodigoEvento).Include(t => t.CodigoPabellon);
            return View(await mvcContext.ToListAsync());
        }

        
        
    }
}
