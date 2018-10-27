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
        VisionDataAccessLayer objadmin = new VisionDataAccessLayer();

        public IActionResult Index()
        {
            List<Evento> lstAdmin = new List<Evento>();
            lstEven = objeven.GetAllEventos().ToList();

            return View(lstEven);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Evento evento)
        {
            if (ModelState.IsValid)
            {
                objadmin.AddEvento(evento);
                return RedirectToAction("Index");
            }
            return View(evento);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Evento evento = objadmin.GetEventoData(id);

            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Evento evento)
        {
            if (id != evento.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objadmin.UpdateEvento(evento);
                return RedirectToAction("Index");
            }
            return View(evento);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Evento evento = objadmin.GetEventoData(id);

            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Evento evento = objadmin.GetEventorData(id);

            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
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