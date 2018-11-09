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
    public class AlumnoController : Controller
    {   

        private readonly MvcContext _context;

        public AlumnoController(MvcContext context)
        {
            _context = context;
        }

        // GET: Alumno
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.Alumno.Include(a => a.CodigoCarrera);
            return View(await mvcContext.ToListAsync());
        }

        // GET: Alumno/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumno
                .Include(a => a.CodigoCarrera)
                .SingleOrDefaultAsync(m => m.DNI == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // GET: Alumno/Create
        public IActionResult Create()
        {
            ViewData["IDCarrera"] = new SelectList(_context.Carrera, "IDCarrera", "IDCarrera");
            return View();
        }

        // GET: Alumno/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumno.SingleOrDefaultAsync(m => m.DNI == id);
            if (alumno == null)
            {
                return NotFound();
            }
            ViewData["IDCarrera"] = new SelectList(_context.Carrera, "IDCarrera", "IDCarrera", alumno.IDCarrera);
            return View(alumno);
        }

        // POST: Alumno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DNI,ApePat,ApeMat,NomAlumno,CorreoAlum,Celular,FechaNac,IDCarrera")] Alumno alumno)
        {
            if (id != alumno.DNI)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alumno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumnoExists(alumno.DNI))
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
            ViewData["IDCarrera"] = new SelectList(_context.Carrera, "IDCarrera", "IDCarrera", alumno.IDCarrera);
            return View(alumno);
        }

    }

}
