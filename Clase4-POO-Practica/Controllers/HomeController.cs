using Clase4_POO_Practica.Models;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;


namespace Clase4_POO_Practica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<DirectorTecnico> winer;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["DTs"] = Datos.DirectoresTecnicos;
            return View();
        }
        [HttpPost]
        public IActionResult Index(int i)
        {
            ViewData["DTs"] = Datos.DirectoresTecnicos;
            winer = PremioBatallaPenales.ObtenerGanadores(Datos.DirectoresTecnicos);
            return View(winer);
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
