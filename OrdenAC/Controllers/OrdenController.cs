using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using OrdenAC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrdenAC.Controllers
{
    public class OrdenController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<OrdenModel> ordenes = new List<OrdenModel>();

            using (var dbContext = new OrdenACDBContext())
            {
                //Ensure database is created
                //dbContext.Database.EnsureCreated();
                if (!dbContext.Ordenes.Any())
                {

                    dbContext.Ordenes.Add(entity: new OrdenModel(oficinaVentaId: 0, cliente: "María Ruiz", producto: "ASUS Neon Pro 2020"));

                    dbContext.SaveChanges();
                }

                foreach (var orden in dbContext.Ordenes)
                {
                    ordenes.Add(new OrdenModel(orden.OficinaVentaId, orden.Cliente, orden.Producto));

                }


            }

            return View("Index", ordenes);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
