using Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase4_POO_Practica.Web.Controllers
{
    public class ArqueroController : Controller
    {
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Arquero arquero)
        {
            arquero.Id = Datos.Arqueros.Count + 1;
            Datos.Arqueros.Add(arquero);
            return Redirect("/Arquero/Crear");
        }
    }
}
