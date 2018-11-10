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
    public class PabellonController : Controller
    {
        private readonly MvcContext _context;

        public PabellonController(MvcContext context)
        {
            _context = context;
        }

        // GET: Pabellon
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pabellon.ToListAsync());
        }

        // GET: Pabellon/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pabellon = await _context.Pabellon
                .SingleOrDefaultAsync(m => m.IDPabellon == id);
            if (pabellon == null)
            {
                return NotFound();
            }

            return View(pabellon);
        }

         // GET: Pabellon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pabellon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDPabellon,NomPab")] Pabellon pabellon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pabellon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pabellon);
        }


         // GET: Pabellon/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pabellon = await _context.Pabellon.SingleOrDefaultAsync(m => m.IDPabellon == id);
            if (pabellon == null)
            {
                return NotFound();
            }
            return View(pabellon);
        }

        // POST: Pabellon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDPabellon,NomPab")] Pabellon pabellon)
        {
            if (id != pabellon.IDPabellon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pabellon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PabellonExists(pabellon.IDPabellon))
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
            return View(pabellon);
        }

        
        // GET: Pabellon/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pabellon = await _context.Pabellon
                .SingleOrDefaultAsync(m => m.IDPabellon == id);
            if (pabellon == null)
            {
                return NotFound();
            }

            return View(pabellon);
        }

        // POST: Pabellon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pabellon = await _context.Pabellon.SingleOrDefaultAsync(m => m.IDPabellon == id);
            _context.Pabellon.Remove(pabellon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PabellonExists(string id)
        {
            return _context.Pabellon.Any(e => e.IDPabellon == id);
        }
    }
}