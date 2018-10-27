using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Controllers
{
    public class EventoController : Controller
    {
        EventoDataAccessLayer objadmin = new EventoDataAccessLayer();

        public IActionResult Index()
        {
            List<Evento> lstAdmin = new List<Evento>();
            lstAdmin = objadmin.GetAllEventoes().ToList();

            return View(lstAdmin);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Evento Evento)
        {
            if (ModelState.IsValid)
            {
                objadmin.AddEvento(Evento);
                return RedirectToAction("Index");
            }
            return View(Evento);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Evento Evento = objadmin.GetEventoData(id);

            if (Evento == null)
            {
                return NotFound();
            }
            return View(Evento);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Evento Evento)
        {
            if (id != Evento.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objadmin.UpdateEvento(Evento);
                return RedirectToAction("Index");
            }
            return View(Evento);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Evento Evento = objadmin.GetEventoData(id);

            if (Evento == null)
            {
                return NotFound();
            }
            return View(Evento);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Evento Evento = objadmin.GetEventoData(id);

            if (Evento == null)
            {
                return NotFound();
            }
            return View(Evento);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objadmin.DeleteEvento(id);
            return RedirectToAction("Index");
        }
    }
}