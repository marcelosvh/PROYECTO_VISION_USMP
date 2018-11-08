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
    public class PabAulaController : Controller
    {
        private readonly MvcContext _context;

        public PabAulaController(MvcContext context)
        {
            _context = context;
        }

        // GET: PabAula
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.PabAula.Include(p => p.CodigoAula).Include(p => p.CodigoPabellon);
            return View(await mvcContext.ToListAsync());
        }

        // GET: PabAula/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pabAula = await _context.PabAula
                .Include(p => p.CodigoAula)
                .Include(p => p.CodigoPabellon)
                .SingleOrDefaultAsync(m => m.IDPabellon == id);
            if (pabAula == null)
            {
                return NotFound();
            }

            return View(pabAula);
        }
