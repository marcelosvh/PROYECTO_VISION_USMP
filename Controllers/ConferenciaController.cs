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
    public class ConferenciaController : Controller
    {

private readonly MvcContext _context;

        public ConferenciaController(MvcContext context)
        {
            _context = context;
        }

        // GET: Conferencia
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.Conferencia.Include(c => c.CodigoAula).Include(c => c.CodigoCarrera).Include(c => c.CodigoEvento).Include(c => c.CodigoPabellon);
            return View(await mvcContext.ToListAsync());
        }
        
    }
}