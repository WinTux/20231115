using Microsoft.AspNetCore.Mvc;
using PasosIniciales.Models;

namespace PasosIniciales.Controllers
{
    [Route("datos")]
    public class DatosVistaController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.edad = 19;
            ViewBag.nombre = "Pepe";
            ViewBag.soltero = true;
            ViewBag.estatura = 1.72;
            ViewBag.fecha_nac = DateTime.Now;//new DateTime(1995, 12, 31);
            return View();
        }

        [Route("objeto")]
        public IActionResult PasandoObjetos() {
            var prod = new Producto()
            {
                Id = 1,
                Nombre = "Queso",
                Precio = 25,
                Cantidad = 12,
                Foto = "queso.jpg"
            };
            ViewBag.producto = prod;
            return View(); 
        }

        [Route("objetos")]
        public IActionResult PasandoListaObjetos()
        {
            var prods = new List<Producto> {
                new Producto()
            {
                Id = 1,
                Nombre = "Queso",
                Precio = 23.5,
                Cantidad = 12,
                Foto = "queso.jpg"
            },
                new Producto()
            {
                Id = 2,
                Nombre = "Atun",
                Precio = 12,
                Cantidad = 40,
                Foto = "atun.jpg"
            },
                new Producto()
            {
                Id = 3,
                Nombre = "Limonada",
                Precio = 5,
                Cantidad = 100,
                Foto = "limonada2.jpg"
            }
            };
            
            ViewBag.productos = prods;
            return View();
        }
    }
}
