using Microsoft.AspNetCore.Mvc;
using PasosIniciales.Models;

namespace PasosIniciales.Controllers
{
    [Route("cuenta")]
    public class FormsController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            var cuentaVistaModelo = new CuentaVistaModelo();
            cuentaVistaModelo.Cuenta = new Cuenta() { 
                Id = 1,
                Disponible = true,
                Genero = "M"
            };
            cuentaVistaModelo.Lenguajes = new List<Lenguaje>() { 
                new Lenguaje()
                {
                    Id = "len01",
                    nombre = "C#",
                    tickeado = true
                },
                new Lenguaje()
                {
                    Id = "len02",
                    nombre = "Java",
                    tickeado = false
                },
                new Lenguaje()
                {
                    Id = "len03",
                    nombre = "Python",
                    tickeado = true
                },
                new Lenguaje()
                {
                    Id = "len04",
                    nombre = "JavaScript",
                    tickeado = false
                }
            };
            var cargos = new List<Cargo>() { 
                new Cargo
                {
                    Id = "crg01",
                    Nombre = "Consultor externo"
                },
                new Cargo
                {
                    Id = "crg02",
                    Nombre = "Auxiliar en desarrollo"
                },
                new Cargo
                {
                    Id = "crg03",
                    Nombre = "Consultor interno"
                }
            };
            cuentaVistaModelo.Cargos = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(cargos, "Id", "Nombre");

            //TODO: Pasar el objeto a la vista y crear la vista... etc.
            return View("Index", cuentaVistaModelo);
        }
        [Route("registrar")]
        public IActionResult Registrar(CuentaVistaModelo cuentaVistaModelo, List<Lenguaje> lenguajes)
        {
            cuentaVistaModelo.Cuenta.Lenguajes = new List<string>();
            foreach (var leng in lenguajes)
                if (leng.tickeado)
                    cuentaVistaModelo.Cuenta.Lenguajes.Add(leng.Id);
            ViewBag.cuenta = cuentaVistaModelo.Cuenta;
            return View("Registrado");
        }
    }
}
