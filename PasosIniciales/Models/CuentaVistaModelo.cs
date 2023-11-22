using Microsoft.AspNetCore.Mvc.Rendering;

namespace PasosIniciales.Models
{
    public class CuentaVistaModelo
    {
        public Cuenta Cuenta { get; set; }
        public List<Lenguaje> Lenguajes { get; set;}
        public SelectList Cargos { get; set; }
    }
}
