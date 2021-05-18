using Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase4_POO_Practica.Web.Controllers
{
    public class DelanteroController : Controller
    {
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Delantero delantero)
        {
            delantero.Id = Datos.Delanteros.Count + 1;
            Datos.Delanteros.Add(delantero);
            return Redirect("/Delantero/Crear");
        }
    }
}
