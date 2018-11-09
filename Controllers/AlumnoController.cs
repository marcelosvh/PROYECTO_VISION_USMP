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

    }

}
