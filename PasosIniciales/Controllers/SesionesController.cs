using Microsoft.AspNetCore.Mvc;
using PasosIniciales.Herramientas;
using PasosIniciales.Models;

namespace PasosIniciales.Controllers
{
    [Route("sesion")]
    public class SesionesController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("edad", 19);
            HttpContext.Session.SetString("usuario","Pepe");
            // Ahora con objetos
            Producto3 prod = new Producto3 { 
                Id = "QS001", 
                Nombre = "Queso menonita", 
                Precio = 30.6 
            };
            Conversor.ObjetoAjson(HttpContext.Session, "producto", prod);
            List<Producto3> prods = new List<Producto3>() { 
                new Producto3
                {
                    Id = "PR01",
                    Nombre = "Atun",
                    Precio = 10.8
                },
                new Producto3
                {
                    Id = "PR02",
                    Nombre = "Sardina",
                    Precio = 20.5
                },
                new Producto3
                {
                    Id = "PR03",
                    Nombre = "Helado",
                    Precio = 13.4
                }
            };
            Conversor.ObjetoAjson(HttpContext.Session, "productos", prods);
            return View();
        }
    }
}
