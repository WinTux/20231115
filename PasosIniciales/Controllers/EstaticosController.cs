using Microsoft.AspNetCore.Mvc;

namespace PasosIniciales.Controllers
{
    [Route("mapaches")]
    public class EstaticosController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
