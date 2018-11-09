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

        // GET: Conferencia/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conferencia = await _context.Conferencia
                .Include(c => c.CodigoAula)
                .Include(c => c.CodigoCarrera)
                .Include(c => c.CodigoEvento)
                .Include(c => c.CodigoPabellon)
                .SingleOrDefaultAsync(m => m.IDConferencia == id);
            if (conferencia == null)
            {
                return NotFound();
            }

            return View(conferencia);
        }

        // GET: Conferencia/Create
        public IActionResult Create()
        {
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula");
            ViewData["IDCarrera"] = new SelectList(_context.Carrera, "IDCarrera", "IDCarrera");
            ViewData["IDEvento"] = new SelectList(_context.Set<Evento>(), "IDEvento", "IDEvento");
            ViewData["IDPabellon"] = new SelectList(_context.Set<Pabellon>(), "IDPabellon", "IDPabellon");
            return View();
        }
        
        // POST: Conferencia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDConferencia,NomConferencia,HoraIni,HoraFin,Fecha,IDPabellon,IDAula,IDCarrera,IDEvento")] Conferencia conferencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conferencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula", conferencia.IDAula);
            ViewData["IDCarrera"] = new SelectList(_context.Carrera, "IDCarrera", "IDCarrera", conferencia.IDCarrera);
            ViewData["IDEvento"] = new SelectList(_context.Set<Evento>(), "IDEvento", "IDEvento", conferencia.IDEvento);
            ViewData["IDPabellon"] = new SelectList(_context.Set<Pabellon>(), "IDPabellon", "IDPabellon", conferencia.IDPabellon);
            return View(conferencia);
        }


    }
}