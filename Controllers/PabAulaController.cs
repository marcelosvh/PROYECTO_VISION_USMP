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
    public class PabAulaController : Controller
    {
        private readonly MvcContext _context;

        public PabAulaController(MvcContext context)
        {
            _context = context;
        }

        // GET: PabAula
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.PabAula.Include(p => p.CodigoAula).Include(p => p.CodigoPabellon);
            return View(await mvcContext.ToListAsync());
        }

        // GET: PabAula/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pabAula = await _context.PabAula
                .Include(p => p.CodigoAula)
                .Include(p => p.CodigoPabellon)
                .SingleOrDefaultAsync(m => m.IDPabellon == id);
            if (pabAula == null)
            {
                return NotFound();
            }

            return View(pabAula);
        }



        // GET: PabAula/Create
        public IActionResult Create()
        {
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula");
            ViewData["IDPabellon"] = new SelectList(_context.Set<Pabellon>(), "IDPabellon", "IDPabellon");
            return View();
        }

        // POST: PabAula/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDPabellon,IDAula,Piso,Capacidad")] PabAula pabAula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pabAula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula", pabAula.IDAula);
            ViewData["IDPabellon"] = new SelectList(_context.Set<Pabellon>(), "IDPabellon", "IDPabellon", pabAula.IDPabellon);
            return View(pabAula);
        }

        // GET: PabAula/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pabAula = await _context.PabAula.SingleOrDefaultAsync(m => m.IDPabellon == id);
            if (pabAula == null)
            {
                return NotFound();
            }
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula", pabAula.IDAula);
            ViewData["IDPabellon"] = new SelectList(_context.Set<Pabellon>(), "IDPabellon", "IDPabellon", pabAula.IDPabellon);
            return View(pabAula);
        }


        // POST: PabAula/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDPabellon,IDAula,Piso,Capacidad")] PabAula pabAula)
        {
            if (id != pabAula.IDPabellon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pabAula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PabAulaExists(pabAula.IDPabellon))
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
            ViewData["IDAula"] = new SelectList(_context.Aula, "IDAula", "IDAula", pabAula.IDAula);
            ViewData["IDPabellon"] = new SelectList(_context.Set<Pabellon>(), "IDPabellon", "IDPabellon", pabAula.IDPabellon);
            return View(pabAula);
        }