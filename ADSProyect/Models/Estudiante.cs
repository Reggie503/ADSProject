using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProyect.Models
{
    [PrimaryKey(nameof(IdEstudiante))]
    public class Estudiante
    {
        private int idEstudiante;
        private string nombreEstudiante;
        private string apellidoEstudiante;
        private string codigoEstuainte;
        private string correoEstudiante;

        //          NOTA: LOS REQUERIMIENTOS SE PONEN ARRIBA DE LAS FUNCIONES

        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor de 50 caracteres")]
        public string NombreEstudiante { get => nombreEstudiante; set => nombreEstudiante = value; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor de 50 caracteres")]
        public string ApellidoEstudiante { get => apellidoEstudiante; set => apellidoEstudiante = value; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor de 12 caracteres")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor de 50 caracteres")]
        public string CodigoEstuainte { get => codigoEstuainte; set => codigoEstuainte = value; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede ser mayor de 254 caracteres")]
        [EmailAddress(ErrorMessage = "El formato de correo electrico no es correcto")]
        public string CorreoEstudiante { get => correoEstudiante; set => correoEstudiante = value; }
        
    }
}
