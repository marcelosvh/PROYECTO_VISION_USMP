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
    public class ExpositorController : Controller
    {
        private readonly MvcContext _context;

        public ExpositorController(MvcContext context)
        {
            _context = context;
        }

        // GET: Expositor
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.Expositor.Include(e => e.CodigoEmpresa);
            return View(await mvcContext.ToListAsync());
        }