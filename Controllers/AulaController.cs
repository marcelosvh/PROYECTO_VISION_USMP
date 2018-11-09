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
    public class AulaController : Controller
    {

        private readonly MvcContext _context;

        public AulaController(MvcContext context)
        {
            _context = context;
        }

        // GET: Aula
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aula.ToListAsync());
        }

        // GET: Aula/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aula = await _context.Aula
                .SingleOrDefaultAsync(m => m.IDAula == id);
            if (aula == null)
            {
                return NotFound();
            }

            return View(aula);
        }

    }

}
