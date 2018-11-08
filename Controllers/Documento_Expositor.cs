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
    public class ExpTipDocController : Controller
    {
        private readonly MvcContext _context;

        public ExpTipDocController(MvcContext context)
        {
            _context = context;
        }
        // GET: ExpTipDoc
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.ExpTipDoc.Include(e => e.CodigoExpositor).Include(e => e.CodigoTipoDocumento);
            return View(await mvcContext.ToListAsync());
        }

        // GET: ExpTipDoc/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expTipDoc = await _context.ExpTipDoc
                .Include(e => e.CodigoExpositor)
                .Include(e => e.CodigoTipoDocumento)
                .SingleOrDefaultAsync(m => m.IDTip == id);
            if (expTipDoc == null)
            {
                return NotFound();
            }

            return View(expTipDoc);
        }

         // GET: ExpTipDoc/Create
        public IActionResult Create()
        {
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor");
            ViewData["IDTip"] = new SelectList(_context.Set<TipoDocumento>(), "IDTip", "IDTip");
            return View();
        }

        // POST: ExpTipDoc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDTip,IDExpositor,Número")] ExpTipDoc expTipDoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expTipDoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor", expTipDoc.IDExpositor);
            ViewData["IDTip"] = new SelectList(_context.Set<TipoDocumento>(), "IDTip", "IDTip", expTipDoc.IDTip);
            return View(expTipDoc);
        }

        // GET: ExpTipDoc/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expTipDoc = await _context.ExpTipDoc.SingleOrDefaultAsync(m => m.IDTip == id);
            if (expTipDoc == null)
            {
                return NotFound();
            }
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor", expTipDoc.IDExpositor);
            ViewData["IDTip"] = new SelectList(_context.Set<TipoDocumento>(), "IDTip", "IDTip", expTipDoc.IDTip);
            return View(expTipDoc);
        }

        // POST: ExpTipDoc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDTip,IDExpositor,Número")] ExpTipDoc expTipDoc)
        {
            if (id != expTipDoc.IDTip)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expTipDoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpTipDocExists(expTipDoc.IDTip))
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
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor", expTipDoc.IDExpositor);
            ViewData["IDTip"] = new SelectList(_context.Set<TipoDocumento>(), "IDTip", "IDTip", expTipDoc.IDTip);
            return View(expTipDoc);
        }
        
        // GET: ExpTipDoc/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expTipDoc = await _context.ExpTipDoc
                .Include(e => e.CodigoExpositor)
                .Include(e => e.CodigoTipoDocumento)
                .SingleOrDefaultAsync(m => m.IDTip == id);
            if (expTipDoc == null)
            {
                return NotFound();
            }

            return View(expTipDoc);
        }

