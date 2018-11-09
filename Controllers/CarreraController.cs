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
    public class CarreraController : Controller
    {
        
        private readonly MvcContext _context;

        public CarreraController(MvcContext context)
        {
            _context = context;
        }

        // GET: Carrera
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carrera.ToListAsync());
        }

        // GET: Carrera/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.Carrera
                .SingleOrDefaultAsync(m => m.IDCarrera == id);
            if (carrera == null)
            {
                return NotFound();
            }

            return View(carrera);
        }

         // GET: Carrera/Create
        public IActionResult Create()
        {
            return View();
        }

          // POST: Carrera/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDCarrera,NomCarrera")] Carrera carrera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carrera);
        }
        
        
        // GET: Carrera/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.Carrera.SingleOrDefaultAsync(m => m.IDCarrera == id);
            if (carrera == null)
            {
                return NotFound();
            }
            return View(carrera);
        }

        // POST: Carrera/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDCarrera,NomCarrera")] Carrera carrera)
        {
            if (id != carrera.IDCarrera)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carrera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarreraExists(carrera.IDCarrera))
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
            return View(carrera);
        }
   
        // GET: Carrera/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.Carrera
                .SingleOrDefaultAsync(m => m.IDCarrera == id);
            if (carrera == null)
            {
                return NotFound();
            }

            return View(carrera);
        }


    }

}