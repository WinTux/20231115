using Microsoft.AspNetCore.Mvc;
using PasosIniciales.Models;

namespace PasosIniciales.Controllers
{
    [Route("tienda")]
    public class TiendaController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            var prodModel = new ProductoModel();
            ViewBag.productos = prodModel.GetTodo();
            return View();
        }
    }
}
