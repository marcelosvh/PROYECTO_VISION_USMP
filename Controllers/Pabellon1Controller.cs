using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Controllers
{
    public class Pabellon1Controller : Controller
    {
        EmployeeDataAccessLayer objpabellon1 = new EmployeeDataAccessLayer();

        public IActionResult Index()
        {
            List<pabellon1> lstPabellon1 = new List<pabellon1>();
            lstPabellon1 = objpabellon1.GetAllPabellon1().ToList();

            return View(lstPabellon1);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Pabellon1 pabellon1)
        {
            if (ModelState.IsValid)
            {
                objemployee.AddPabellon1(pabellon1);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Pabellon1 pabellon1 = objpabellon1.GetPabellon1Data(id);

            if (pabellon1 == null)
            {
                return NotFound();
            }
            return View(pabellon1);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind]Pabellon1 pabellon)
        {
            if (id != pabellon1.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objemployee.UpdatePabellon1(pabellon1);
                return RedirectToAction("Index");
            }
            return View(pabellon1);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Pabellon1 pabellon1 = objpabellon1.GetPabellon1Data(id);

            if (pabellon1 == null)
            {
                return NotFound();
            }
            return View(pabellon1);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Pabellon1 pabellon1 = objpabellon1.GetPabellon1Data(id);

            if (pabellon1 == null)
            {
                return NotFound();
            }
            return View(pabellon1);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objemployee.DeletePabellon1(id);
            return RedirectToAction("Index");
        }
    }
}