namespace PasosIniciales.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Descripcion { get; set; }
        public bool Disponible { get; set; }
        public List<string> Lenguajes { get; set; }// len01, len02, len03
        public string Genero { get; set; } //M, F
        public string Cargo { get; set; }// crg01, crg02, crg03
    }
}
