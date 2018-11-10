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

        // GET: RequisitosTaller/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisitosTaller = await _context.RequisitosTaller
                .Include(r => r.CodigoExpositor)
                .Include(r => r.CodigoTaller)
                .SingleOrDefaultAsync(m => m.IDExpositor == id);
            if (requisitosTaller == null)
            {
                return NotFound();
            }

            return View(requisitosTaller);
        }

        // GET: RequisitosTaller/Create
        public IActionResult Create()
        {
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor");
            ViewData["IDTaller"] = new SelectList(_context.Set<Taller>(), "IDTaller", "IDTaller");
            return View();
        }

        // POST: RequisitosTaller/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDExpositor,IDTaller,DescReqTal")] RequisitosTaller requisitosTaller)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requisitosTaller);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor", requisitosTaller.IDExpositor);
            ViewData["IDTaller"] = new SelectList(_context.Set<Taller>(), "IDTaller", "IDTaller", requisitosTaller.IDTaller);
            return View(requisitosTaller);
        }

        // GET: RequisitosTaller/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisitosTaller = await _context.RequisitosTaller.SingleOrDefaultAsync(m => m.IDExpositor == id);
            if (requisitosTaller == null)
            {
                return NotFound();
            }
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor", requisitosTaller.IDExpositor);
            ViewData["IDTaller"] = new SelectList(_context.Set<Taller>(), "IDTaller", "IDTaller", requisitosTaller.IDTaller);
            return View(requisitosTaller);
        }

        // POST: RequisitosTaller/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDExpositor,IDTaller,DescReqTal")] RequisitosTaller requisitosTaller)
        {
            if (id != requisitosTaller.IDExpositor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requisitosTaller);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequisitosTallerExists(requisitosTaller.IDExpositor))
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
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor", requisitosTaller.IDExpositor);
            ViewData["IDTaller"] = new SelectList(_context.Set<Taller>(), "IDTaller", "IDTaller", requisitosTaller.IDTaller);
            return View(requisitosTaller);
        }

        // GET: RequisitosTaller/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisitosTaller = await _context.RequisitosTaller
                .Include(r => r.CodigoExpositor)
                .Include(r => r.CodigoTaller)
                .SingleOrDefaultAsync(m => m.IDExpositor == id);
            if (requisitosTaller == null)
            {
                return NotFound();
            }

            return View(requisitosTaller);
        }

        // POST: RequisitosTaller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var requisitosTaller = await _context.RequisitosTaller.SingleOrDefaultAsync(m => m.IDExpositor == id);
            _context.RequisitosTaller.Remove(requisitosTaller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequisitosTallerExists(string id)
        {
            return _context.RequisitosTaller.Any(e => e.IDExpositor == id);
        }
    }
}
