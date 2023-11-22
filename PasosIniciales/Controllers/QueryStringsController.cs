using Microsoft.AspNetCore.Mvc;

namespace PasosIniciales.Controllers
{
    [Route("query")]
    public class QueryStringsController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("ejemplo1")]
        public IActionResult ejemplo1([FromQuery(Name = "cod")] string codigo)
        {
            ViewBag.codigo = codigo;
            return View("ejemplo1");
        }
        [Route("ejemplo2")]
        public IActionResult ejemplo2([FromQuery(Name = "page")] int pagina, [FromQuery(Name = "cod")] string codigo)
        {
            ViewBag.pag = pagina;
            ViewBag.codigo = codigo;
            return View("ejemplo2");
        }
        [Route("ejemplo3")]
        public IActionResult ejemplo3()
        {
            int pagina = int.Parse(HttpContext.Request.Query["page"].ToString());
            string codigo = HttpContext.Request.Query["cod"].ToString();
            ViewBag.pag = pagina;
            ViewBag.codigo = codigo;
            return View("ejemplo3");
        }
    }
}
