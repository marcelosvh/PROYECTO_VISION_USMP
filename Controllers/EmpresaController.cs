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
    public class EmpresaController : Controller
    {

       private readonly MvcContext _context;

        public EmpresaController(MvcContext context)
        {
            _context = context;
        }

        // GET: Empresa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empresa.ToListAsync());
        }

        // GET: Empresa/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresa
                .SingleOrDefaultAsync(m => m.IDEmpresa == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }   

        // GET: Empresa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDEmpresa,NomEmpresa,CorreoEmpresa,Pais,Telefono")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empresa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empresa);
        }

 // GET: Empresa/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresa.SingleOrDefaultAsync(m => m.IDEmpresa == id);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);
        }

// POST: Empresa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDEmpresa,NomEmpresa,CorreoEmpresa,Pais,Telefono")] Empresa empresa)
        {
            if (id != empresa.IDEmpresa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empresa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpresaExists(empresa.IDEmpresa))
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
            return View(empresa);
        }

        // GET: Empresa/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresa
                .SingleOrDefaultAsync(m => m.IDEmpresa == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

         // POST: Empresa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var empresa = await _context.Empresa.SingleOrDefaultAsync(m => m.IDEmpresa == id);
            _context.Empresa.Remove(empresa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpresaExists(string id)
        {
            return _context.Empresa.Any(e => e.IDEmpresa == id);
        }
        
    }
}