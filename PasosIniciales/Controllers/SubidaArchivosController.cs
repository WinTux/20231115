using Microsoft.AspNetCore.Mvc;
using PasosIniciales.Models;

namespace PasosIniciales.Controllers
{
    [Route("subida")]
    public class SubidaArchivosController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;

        public SubidaArchivosController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        [Route("index")]
        public IActionResult Index()
        {
            return View("Index", new Producto());
        }
        [Route("index2")]
        public IActionResult Index2()
        {
            return View("Index2", new Producto2());
        }
        [Route("guardar")]
        [HttpPost]
        public IActionResult Guardar(Producto producto, IFormFile foto) {
            if(foto == null || foto.Length == 0)
            {
                return Content("Imagen no agregada!!");
            }
            else
            {
                var Ruta = Path.Combine(this.webHostEnvironment.WebRootPath, "images", foto.FileName);// C:\Usuario\Pepe\App\SuperServer\...\images\atun.jpg
                var stream = new FileStream(Ruta, FileMode.Create);
                foto.CopyToAsync(stream);
                producto.Foto = foto.FileName;
                stream.Close();
                stream.Dispose();
            }
            ViewBag.producto = producto;
            return View("Guardado"); 
        }

        [Route("guardar2")]
        [HttpPost]
        public IActionResult GuardarVarios(Producto2 producto, IFormFile[] fotos)
        {// IFormFile[] fotos
            if (fotos == null || fotos.Length == 0)
            {
                return Content("Imagenes no agregadas!!");
            }
            else
            {
                //TODO:  crear foreach y crear vista para mostrar fotos de producto.
                producto.Fotos = new List<string>();
                foreach(var foto in fotos)
                {
                    var Ruta = Path.Combine(this.webHostEnvironment.WebRootPath, "images", foto.FileName);// C:\Usuario\Pepe\App\SuperServer\...\images\atun.jpg
                    var stream = new FileStream(Ruta, FileMode.Create);
                    foto.CopyToAsync(stream);
                    producto.Fotos.Add(foto.FileName);
                }
                
            }
            ViewBag.producto = producto;
            return View("Guardado2");
        }
    }

}
