using System.ComponentModel.DataAnnotations;

namespace T2_Ramos_Kevin.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del distribuidor es obligatorio.")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "La razón social es obligatoria.")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "El número de teléfono debe contener 9 dígitos.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El año de inicio de operaciones es obligatorio.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "El año de inicio de operaciones debe tener 4 dígitos.")]
        [Range(1900, 3000, ErrorMessage = "El año de inicio de operaciones debe estar entre 1900 y 3000.")]
        public int AnioInicioOperacion { get; set; }

        [Required(ErrorMessage = "El contacto es obligatorio.")]
        public string Contacto { get; set; }

    }
}
