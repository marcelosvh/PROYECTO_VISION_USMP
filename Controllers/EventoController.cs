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
