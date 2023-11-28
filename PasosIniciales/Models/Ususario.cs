using System.ComponentModel.DataAnnotations;

namespace PasosIniciales.Models
{
    public class Usuario
    {
        [Required]
        [MinLength(3, ErrorMessage ="El nombre de usuario debe ser de 3 letras o mas")]
        [MaxLength(15)]
        public string Nombre { get; set; }
        [Required]
        [MinLength(5,ErrorMessage = "Por favor, ingrese un  password con un minimo de 5 caracteres")]
        [MaxLength(20)]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{5,20})", ErrorMessage = "El password debe contener minusculas, mayusculas, numeros y simbolos (@#$%)")]
        public string Password { get; set; }
        [Required]
        [Range(18,30, ErrorMessage = "La edad debe estar entre 18 y 30")]
        public int Edad {  get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Url]
        public string PaginaWeb { get; set; }
    }
}
