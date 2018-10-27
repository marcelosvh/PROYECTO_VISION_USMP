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
            List<Documento_Expositor> lstAdmin = new List<Documento_Expositor>();
            lstAdmin = objadmin.GetAllDocumento_Expositores().ToList();

            return View(lstAdmin);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Documento_Expositor Documento_Expositor)
        {
            if (ModelState.IsValid)
            {
                objadmin.AddDocumento_Expositor(Documento_Expositor);
                return RedirectToAction("Index");
            }
            return View(Documento_Expositor);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Documento_Expositor Documento_Expositor = objadmin.GetDocumento_ExpositorData(id);

            if (Documento_Expositor == null)
            {
                return NotFound();
            }
            return View(Documento_Expositor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Documento_Expositor Documento_Expositor)
        {
            if (id != Documento_Expositor.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objadmin.UpdateDocumento_Expositor(Documento_Expositor);
                return RedirectToAction("Index");
            }
            return View(Documento_Expositor);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Documento_Expositor Documento_Expositor = objadmin.GetDocumento_ExpositorData(id);

            if (Documento_Expositor == null)
            {
                return NotFound();
            }
            return View(Documento_Expositor);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Documento_Expositor Documento_Expositor = objadmin.GetDocumento_ExpositorData(id);

            if (Documento_Expositor == null)
            {
                return NotFound();
            }
            return View(Documento_Expositor);
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