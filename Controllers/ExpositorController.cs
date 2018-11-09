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
    public class ExpositorController : Controller
    {
        private readonly MvcContext _context;

        public ExpositorController(MvcContext context)
        {
            _context = context;
        }

        // GET: Expositor
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.Expositor.Include(e => e.CodigoEmpresa);
            return View(await mvcContext.ToListAsync());
        }

        // GET: Expositor/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expositor = await _context.Expositor
                .Include(e => e.CodigoEmpresa)
                .SingleOrDefaultAsync(m => m.IDExpositor == id);
            if (expositor == null)
            {
                return NotFound();
            }

            return View(expositor);
        }

        // GET: Expositor/Create
        public IActionResult Create()
        {
            ViewData["IDEmpresa"] = new SelectList(_context.Empresa, "IDEmpresa", "IDEmpresa");
            return View();
        }

        // POST: Expositor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDExpositor,ApePat,ApeMat,NomExp,Nacionalidad,TipoOrador,CorreoExp,Orden,IDEmpresa")] Expositor expositor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expositor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDEmpresa"] = new SelectList(_context.Empresa, "IDEmpresa", "IDEmpresa", expositor.IDEmpresa);
            return View(expositor);
        }

        // GET: Expositor/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expositor = await _context.Expositor.SingleOrDefaultAsync(m => m.IDExpositor == id);
            if (expositor == null)
            {
                return NotFound();
            }
            ViewData["IDEmpresa"] = new SelectList(_context.Empresa, "IDEmpresa", "IDEmpresa", expositor.IDEmpresa);
            return View(expositor);
        }

        // POST: Expositor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDExpositor,ApePat,ApeMat,NomExp,Nacionalidad,TipoOrador,CorreoExp,Orden,IDEmpresa")] Expositor expositor)
        {
            if (id != expositor.IDExpositor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expositor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpositorExists(expositor.IDExpositor))
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
            ViewData["IDEmpresa"] = new SelectList(_context.Empresa, "IDEmpresa", "IDEmpresa", expositor.IDEmpresa);
            return View(expositor);
        }

        // GET: Expositor/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expositor = await _context.Expositor
                .Include(e => e.CodigoEmpresa)
                .SingleOrDefaultAsync(m => m.IDExpositor == id);
            if (expositor == null)
            {
                return NotFound();
            }

            return View(expositor);
        }

        // POST: Expositor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var expositor = await _context.Expositor.SingleOrDefaultAsync(m => m.IDExpositor == id);
            _context.Expositor.Remove(expositor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpositorExists(string id)
        {
            return _context.Expositor.Any(e => e.IDExpositor == id);
        }
    }
}
