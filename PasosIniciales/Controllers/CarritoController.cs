using Microsoft.AspNetCore.Mvc;
using PasosIniciales.Models;

namespace PasosIniciales.Controllers
{
    [Route("carrito")]
    public class CarritoController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("comprar/{id}")]
        public IActionResult Comprar(string id)
        {
            ProductoModel productoModel = new ProductoModel();
            // preguntar si la variable de sesion ya existe
            // si no existe: crear la variable de sesion e ingresar el producto (rescatandolo por su id)
            // si ya existe: verificar si el producto esta dentro el carrito
            //                 si esta: incrementamos cantidad
            //                  si no esta: agregamos producto con cantidad 1 (item)
            return View();
        }
    }


}
