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


    }

}