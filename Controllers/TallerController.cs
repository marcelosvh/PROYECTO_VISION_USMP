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

        // GET: Taller/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taller = await _context.Taller
                .Include(t => t.CodigoAula)
                .Include(t => t.CodigoCarrera)
                .Include(t => t.CodigoEvento)
                .Include(t => t.CodigoPabellon)
                .SingleOrDefaultAsync(m => m.IDTaller == id);
            if (taller == null)
            {
                return NotFound();
            }

            return View(taller);
        }

        // GET: Taller/Create
        public IActionResult Create()
        {
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula");
            ViewData["IDCarrera"] = new SelectList(_context.Carrera, "IDCarrera", "IDCarrera");
            ViewData["IDEvento"] = new SelectList(_context.Evento, "IDEvento", "IDEvento");
            ViewData["IDPabellon"] = new SelectList(_context.Pabellon, "IDPabellon", "IDPabellon");
            return View();
        }

        // POST: Taller/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDTaller,NomTaller,HoraIni,HoraFin,Fecha,IDPabellon,IDAula,IDCarrera,IDEvento")] Taller taller)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taller);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula", taller.IDAula);
            ViewData["IDCarrera"] = new SelectList(_context.Carrera, "IDCarrera", "IDCarrera", taller.IDCarrera);
            ViewData["IDEvento"] = new SelectList(_context.Evento, "IDEvento", "IDEvento", taller.IDEvento);
            ViewData["IDPabellon"] = new SelectList(_context.Pabellon, "IDPabellon", "IDPabellon", taller.IDPabellon);
            return View(taller);
        }

        // GET: Taller/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taller = await _context.Taller.SingleOrDefaultAsync(m => m.IDTaller == id);
            if (taller == null)
            {
                return NotFound();
            }
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula", taller.IDAula);
            ViewData["IDCarrera"] = new SelectList(_context.Carrera, "IDCarrera", "IDCarrera", taller.IDCarrera);
            ViewData["IDEvento"] = new SelectList(_context.Evento, "IDEvento", "IDEvento", taller.IDEvento);
            ViewData["IDPabellon"] = new SelectList(_context.Pabellon, "IDPabellon", "IDPabellon", taller.IDPabellon);
            return View(taller);
        }

        // POST: Taller/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDTaller,NomTaller,HoraIni,HoraFin,Fecha,IDPabellon,IDAula,IDCarrera,IDEvento")] Taller taller)
        {
            if (id != taller.IDTaller)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taller);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TallerExists(taller.IDTaller))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula", taller.IDAula);
            ViewData["IDCarrera"] = new SelectList(_context.Carrera, "IDCarrera", "IDCarrera", taller.IDCarrera);
            ViewData["IDEvento"] = new SelectList(_context.Evento, "IDEvento", "IDEvento", taller.IDEvento);
            ViewData["IDPabellon"] = new SelectList(_context.Pabellon, "IDPabellon", "IDPabellon", taller.IDPabellon);
            return View(taller);
        }

        // GET: Taller/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taller = await _context.Taller
                .Include(t => t.CodigoAula)
                .Include(t => t.CodigoCarrera)
                .Include(t => t.CodigoEvento)
                .Include(t => t.CodigoPabellon)
                .SingleOrDefaultAsync(m => m.IDTaller == id);
            if (taller == null)
            {
                return NotFound();
            }

            return View(taller);
        }

        // POST: Taller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var taller = await _context.Taller.SingleOrDefaultAsync(m => m.IDTaller == id);
            _context.Taller.Remove(taller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TallerExists(string id)
        {
            return _context.Taller.Any(e => e.IDTaller == id);
        }
    }
}
