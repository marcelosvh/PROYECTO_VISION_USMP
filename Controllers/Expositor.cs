using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Controllers
{
    public class ExpositorController : Controller
    {
        ExpositorDataAccessLayer objexpo = new ExpositorDataAccessLayer();

        public IActionResult Index()
        {
            List<Expositor> lstExpo = new List<Expositor>();
            lstExpo = objexpo.GetAllExpositores().ToList();

            return View(lstExpo);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Expositor expositor)
        {
            if (ModelState.IsValid)
            {
                objadmin.AddExpositor(expositor);
                return RedirectToAction("Index");
            }
            return View(expositor);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Expositor expositor = objadmin.GetExpositorData(id);

            if (expositor == null)
            {
                return NotFound();
            }
            return View(expositor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Expositor expositor)
        {
            if (id != expositor.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objexpo.UpdateExpositor(expositor);
                return RedirectToAction("Index");
            }
            return View(expositor);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Expositor expositor = objexpo.GetExpositorData(id);

            if (expositor == null)
            {
                return NotFound();
            }
            return View(expositor);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Expositor expositor = objadmin.GetExpositorData(id);

            if (expositor == null)
            {
                return NotFound();
            }
            return View(expositor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objadmin.DeleteExpositor(id);
            return RedirectToAction("Index");
        }
    }
}