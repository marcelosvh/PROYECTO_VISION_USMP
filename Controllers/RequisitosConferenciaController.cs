using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROYECTO_VISION_USMP.Models;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Controllers9
{
    public class RequisitosConferenciaController : Controller
    {
        private readonly MvcContext _context;

        public RequisitosConferenciaController(MvcContext context)
        {
            _context = context;
        }

        // GET: RequisitosConferencia
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.RequisitosConferencia.Include(r => r.CodigoConferencia).Include(r => r.CodigoExpositor);
            return View(await mvcContext.ToListAsync());
        }

        // GET: RequisitosConferencia/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisitosConferencia = await _context.RequisitosConferencia
                .Include(r => r.CodigoConferencia)
                .Include(r => r.CodigoExpositor)
                .SingleOrDefaultAsync(m => m.IDExpositor == id);
            if (requisitosConferencia == null)
            {
                return NotFound();
            }

            return View(requisitosConferencia);
        }

          // GET: RequisitosConferencia/Create
        public IActionResult Create()
        {
            ViewData["IDConferencia"] = new SelectList(_context.Conferencia, "IDConferencia", "IDConferencia");
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor");
            return View();
        }

        // POST: RequisitosConferencia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDExpositor,IDConferencia,DescReqConf")] RequisitosConferencia requisitosConferencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requisitosConferencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDConferencia"] = new SelectList(_context.Conferencia, "IDConferencia", "IDConferencia", requisitosConferencia.IDConferencia);
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor", requisitosConferencia.IDExpositor);
            return View(requisitosConferencia);
        }

 // GET: RequisitosConferencia/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisitosConferencia = await _context.RequisitosConferencia.SingleOrDefaultAsync(m => m.IDExpositor == id);
            if (requisitosConferencia == null)
            {
                return NotFound();
            }
            ViewData["IDConferencia"] = new SelectList(_context.Conferencia, "IDConferencia", "IDConferencia", requisitosConferencia.IDConferencia);
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor", requisitosConferencia.IDExpositor);
            return View(requisitosConferencia);
        }

        // POST: RequisitosConferencia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDExpositor,IDConferencia,DescReqConf")] RequisitosConferencia requisitosConferencia)
        {
            if (id != requisitosConferencia.IDExpositor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requisitosConferencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequisitosConferenciaExists(requisitosConferencia.IDExpositor))
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
            ViewData["IDConferencia"] = new SelectList(_context.Conferencia, "IDConferencia", "IDConferencia", requisitosConferencia.IDConferencia);
            ViewData["IDExpositor"] = new SelectList(_context.Expositor, "IDExpositor", "IDExpositor", requisitosConferencia.IDExpositor);
            return View(requisitosConferencia);
        }