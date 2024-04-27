using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
	public class Materia
	{
        private int idMateria;
        private string nombreMateria;
        public int IdMateria { get => idMateria; set => idMateria = value; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor de 50 caracteres")]
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
    }
}
