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