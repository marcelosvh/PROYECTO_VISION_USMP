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

    }

}