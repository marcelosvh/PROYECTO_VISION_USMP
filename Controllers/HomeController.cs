using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;


namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Alumno()
        {
            ViewData["Message"] = "Your alumno page.";

            return View();
        }
        public IActionResult Administrador()
        {
            ViewData["Message"] = "Your administrador page.";

            return View();
        }

        public IActionResult Aula()
        {
            ViewData["Message"] = "Your aula page.";

            return View();
        }
        public IActionResult Carrera()
        {
            ViewData["Message"] = "Your carrera page.";

            return View();
        }
        public IActionResult Conferencia()
        {
            ViewData["Message"] = "Your conferencia page.";

            return View();
        }
        public IActionResult Crear_cuenta()
        {
            ViewData["Message"] = "Your crear_cuenta page.";

            return View();
        }
        public IActionResult Documento_expositor()
        {
            ViewData["Message"] = "Your documento_expositor page.";

            return View();
        }
        public IActionResult Empresa()
        {
            ViewData["Message"] = "Your empresa page.";

            return View();
        }
        public IActionResult Evento()
        {
            ViewData["Message"] = "Your evento page.";

            return View();
        }
        public IActionResult Expositor()
        {
            ViewData["Message"] = "Your expositor page.";

            return View();
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "Your login page.";

            return View();
        }
        public IActionResult Pabellon_Aula()
        {
            ViewData["Message"] = "Your pabellon_aula page.";

            return View();
        }
        public IActionResult Pabellon()
        {
            ViewData["Message"] = "Your pabellon page.";

            return View();
        }
        public IActionResult Requisitos_Conferencia()
        {
            ViewData["Message"] = "Your requisitos_conferencia page.";

            return View();
        }
        public IActionResult Requisitos_Taller()
        {
            ViewData["Message"] = "Your requisitos_taller page.";

            return View();
        }
        public IActionResult Taller()
        {
            ViewData["Message"] = "Your taller page.";

            return View();
        }
        public IActionResult Tipo_Documento()
        {
            ViewData["Message"] = "Your tipo de documento page.";

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
