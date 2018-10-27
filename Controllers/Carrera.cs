using System;

using System.Collections.Generic;

using System.Diagnostics;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;



namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Controllers

{

public class Carrera : Controller

{

VisionDataAccessLayer objexpo = new VisionDataAccessLayer();



public IActionResult Index()

{

List<Carrera> lstExpo = new List<Carrera>();

lstCar = objexpo.GetAllCarreras().ToList();



return View(lstCar);

}

[HttpGet]

public IActionResult Create()

{

return View();

}



[HttpPost]

[ValidateAntiForgeryToken]

public IActionResult Create([Bind] Carrera carrera)

{

if (ModelState.IsValid)

{

objadmin.AddCarrera(carrera);

return RedirectToAction("Index");

}

return View(carrera);

}



[HttpGet]

public IActionResult Edit(int? id)

{

if (id == null)

{

return NotFound();

}

Carrera carrera = objadmin.GetExpositorData(id);



if (carrera == null)

{

return NotFound();

}

return View(carrera);

}



[HttpPost]

[ValidateAntiForgeryToken]

public IActionResult Edit(int id, [Bind] Carrera carrera)

{

if (id != carrera.ID)

{

return NotFound();

}

if (ModelState.IsValid)

{

objcar.UpdateExpositor(carrera);

return RedirectToAction("Index");

}

return View(carrera);

}



[HttpGet]

public IActionResult Details(int? id)

{

if (id == null)

{

return NotFound();

}

Carrera carrera = objcar.GetCarreraData(id);



if (carrera == null)

{

return NotFound();

}

return View(Carrera);

}



[HttpGet]

public IActionResult Delete(int? id)

{

if (id == null)

{

return NotFound();

}

Carrera carrera= objadmin.GetCarreraData(id);



if (carrera == null)

{

return NotFound();

}

return View(carrera);

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