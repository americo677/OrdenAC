using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrdenAC.Models;

namespace OrdenAC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult RegistrarOrden()
        {
            ViewBag.Message = "Este es un mensaje para el ViewBag";

            return View("RegistrarOrden");
        }

        public IActionResult ConsultarOrden()
        {

            List<OrdenModel> ordenes = new List<OrdenModel>();

            using (var dbContext = new OrdenACDBContext())
            {
                ordenes = new List<OrdenModel>(dbContext.Ordenes);
            }
            return View("ConsultarOrden", ordenes);
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
