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
    public class EventoController : Controller
    {
        private readonly MvcContext _context;

        public EventoController(MvcContext context)
        {
            _context = context;
        }
         // GET: Evento
        public async Task<IActionResult> Index()
        {
            return View(await _context.Evento.ToListAsync());
        }

         // GET: Evento/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento = await _context.Evento
                .SingleOrDefaultAsync(m => m.IDEvento == id);
            if (evento == null)
            {
                return NotFound();
            }

            return View(evento);
        }

         // GET: Evento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Evento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDEvento,TemaEvento,Fecha_Ini,Fecha_Fin")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(evento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(evento);
        }

        // GET: Evento/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento = await _context.Evento.SingleOrDefaultAsync(m => m.IDEvento == id);
            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }
