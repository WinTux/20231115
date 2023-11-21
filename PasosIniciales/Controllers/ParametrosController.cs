using Microsoft.AspNetCore.Mvc;

namespace PasosIniciales.Controllers
{
    public class ParametrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("ejemplo1/{id}")]
        public IActionResult ejemplo1(int id)
        {
            ViewBag.id = id;
            return View("resultado1");
        }

        [Route("ejemplo2/{modelo}/{color}")]
        public IActionResult ejemplo2(string modelo, string color)
        {
            ViewBag.modelo = modelo;
            ViewBag.color = color;
            return View("resultado2");
        }
    }
}
