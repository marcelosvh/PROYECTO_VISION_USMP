using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Controllers
{
    public class Documento_ExpositorController : Controller
    {
        Documento_ExpositorDataAccessLayer objadmin = new Documento_ExpositorDataAccessLayer();

        public IActionResult Index()
        {
            List<Documento_Expositor> lstDoc_exp = new List<Documento_Expositor>();
            lstDoc_exp = objdoc_exp.GetAllDocumento_Expositor().ToList();

            return View(lstDoc_exp);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Documento_Expositor documento_expositor)
        {
            if (ModelState.IsValid)
            {
                objadmin.AddDocumento_Expositor(documento_expositor);
                return RedirectToAction("Index");
            }
            return View(documento_expositor);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Documento_Expositor documento_expositor = objadmin.GetDocumento_ExpositorData(id);

            if (documento_expositor == null)
            {
                return NotFound();
            }
            return View(documento_expositor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Documento_Expositor documento_expositor)
        {
            if (id != documento_expositor.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objadmin.UpdateDocumento_Expositor(documento_expositor);
                return RedirectToAction("Index");
            }
            return View(documento_expositor);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Documento_Expositor documento_expositor = objadmin.GetDocumento_ExpositorrData(id);

            if (documento_expositor == null)
            {
                return NotFound();
            }
            return View(documento_expositor);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Documento_Expositor documento_expositor = objadmin.GetDocumento_ExpositorData(id);

            if (documento_expositor == null)
            {
                return NotFound();
            }
            return View(documento_expositor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objadmin.DeleteDocumento_Expositor(id);
            return RedirectToAction("Index");
        }
    }
}