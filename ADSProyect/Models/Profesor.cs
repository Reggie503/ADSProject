using ADSProyect.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProyect.Models
{
    [PrimaryKey(nameof(IdProfesor))]
    public class Profesor
    {
        public int IdProfesor { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor de 50 caracteres")]
        public string NombresProfesor { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor de 50 caracteres")]
        public string ApellidosProfesor { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede ser mayor de 254 caracteres")]
        [EmailAddress(ErrorMessage = "El formato de correo electrico no es correcto")]
        public string Email { get; set; }
    }
}
