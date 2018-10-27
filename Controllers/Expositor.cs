using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Controllers
{
    public class Expositor
Controller : Controller
    {
        Expositor
    DataAccessLayer objadmin = new Expositor
    DataAccessLayer();

        public IActionResult Index()
        {
            List<Expositor
        > lstAdmin = new List<Expositor
        >();
            lstAdmin = objadmin.GetAllExpositor
        es().ToList();

            return View(lstAdmin);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Expositor
     Expositor
    )
        {
            if (ModelState.IsValid)
            {
                objadmin.AddExpositor
            (Expositor
            );
                return RedirectToAction("Index");
            }
            return View(Expositor
        );
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Expositor
         Expositor
         = objadmin.GetExpositor
        Data(id);

            if (Expositor
         == null)
            {
                return NotFound();
            }
            return View(Expositor
        );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Expositor
     Expositor
    )
        {
            if (id != Expositor
        .ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objadmin.UpdateExpositor
            (Expositor
            );
                return RedirectToAction("Index");
            }
            return View(Expositor
        );
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Expositor
         Expositor
         = objadmin.GetExpositor
        Data(id);

            if (Expositor
         == null)
            {
                return NotFound();
            }
            return View(Expositor
        );
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Expositor
         Expositor
         = objadmin.GetExpositor
        Data(id);

            if (Expositor
         == null)
            {
                return NotFound();
            }
            return View(Expositor
        );
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objadmin.DeleteExpositor
        (id);
            return RedirectToAction("Index");
        }
    }
}