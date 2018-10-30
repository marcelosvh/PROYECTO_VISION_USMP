using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.MvcContext;
using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;

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
            return View(await _context.Taller.ToListAsync());
        }

        // GET: Taller/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taller = await _context.Taller
                .SingleOrDefaultAsync(m => m.idtaller == id);
            if (taller == null)
            {
                return NotFound();
            }

            return View(taller);
        }

        // GET: Taller/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Taller/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idtaller,,taller,hora_ini,hora_fin,fecha,idpab,idaula,idcarrera,idevento")] Taller taller)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taller);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View(taller);
        }

        // GET: Taller/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taller = await _context.Taller.SingleOrDefaultAsync(m => m.idtaller == id);
            if (taller == null)
            {
                return NotFound();
            }
            return View(taller);
        }

        // POST: Taller/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idtaller,,taller,hora_ini,hora_fin,fecha,idpab,idaula,idcarrera,idevento")] Taller taller)
        {
            if (id != taller.idtaller)
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
                    if (!TallerExists(taller.idtaller))
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
            return View(taller);
        }

        // GET: Taller/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taller = await _context.Taller
                .SingleOrDefaultAsync(m => m.idtaller == id);
            if (taller == null)
            {
                return NotFound();
            }

            return View(taller);
        }

        // POST: Taller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taller = await _context.Taller.SingleOrDefaultAsync(m => m.idtaller == id);
            _context.Taller.Remove(taller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TallerExists(int id)
        {
            return _context.Taller.Any(e => e.idtaller == id);
        }
    }
}