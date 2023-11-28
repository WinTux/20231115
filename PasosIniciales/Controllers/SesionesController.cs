using Microsoft.AspNetCore.Mvc;
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
                Nnombre = "Queso menonita", 
                Precio = 30.6 
            };
            return View();
        }
    }
}
