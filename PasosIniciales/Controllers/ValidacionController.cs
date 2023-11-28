using Microsoft.AspNetCore.Mvc;
using PasosIniciales.Models;

namespace PasosIniciales.Controllers
{
    [Route("validacion")]
    public class ValidacionController : Controller
    {
        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", new Usuario());
        }
        [Route("guardar")]
        [HttpPost]
        public IActionResult Guardar(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                ViewBag.usuario = usuario;
                return View("Registrado");
            }else
                return View("Index", new Usuario());//No es necesario pasarle el modelo
        }
    }
}
