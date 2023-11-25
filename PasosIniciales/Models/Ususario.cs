using System.ComponentModel.DataAnnotations;

namespace PasosIniciales.Models
{
    public class Usuario
    {
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Nombre { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{5,20})")]
        public string Password { get; set; }
        [Required]
        [Range(18,30)]
        public int Edad {  get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Url]
        public string PaginaWeb { get; set; }
    }
}
