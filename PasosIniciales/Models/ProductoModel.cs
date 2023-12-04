using System.Linq;
namespace PasosIniciales.Models
{
    public class ProductoModel
    {
        private List<Producto3> productos;
        public ProductoModel()
        {
            productos = new List<Producto3>() {
                new Producto3
                {
                    Id = "PR01",
                    Nombre = "Atun",
                    Precio = (Decimal)10.8,
                    Foto = "atun.jpg"
                },
                new Producto3
                {
                    Id = "PR02",
                    Nombre = "Sardina",
                    Precio = (Decimal)20.5,
                    Foto = "sardina.png"
                },
                new Producto3
                {
                    Id = "PR03",
                    Nombre = "Helado",
                    Precio = (Decimal)13.4,
                    Foto = "helado3.jpg"
                }
            };
        }
        public List<Producto3> GetTodo() {
            return productos;
        }
        public Producto3 GetById(string id) {
            return productos.Single(p => p.Id.Equals(id));//SELECT * FROM producto3 WHERE Id = id;
        }
    }
}
