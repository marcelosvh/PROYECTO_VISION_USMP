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

        
