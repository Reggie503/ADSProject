using System.ComponentModel.DataAnnotations;

namespace ADSProyect.Models
{
    public class Carrera
    {
        private int idCarrera;
        private string codigoCarrera;
        private string nombreCarrera;

        public int IdCarrera { get => idCarrera; set => idCarrera = value; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 3, ErrorMessage = "La longitud del campo no puede ser mayor de 3 caracteres")]
        public string CodigoCarrera { get => codigoCarrera; set => codigoCarrera = value; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 40, ErrorMessage = "La longitud del campo no puede ser mayor de 40 caracteres")]
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
    }
}
