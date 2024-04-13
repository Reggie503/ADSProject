namespace ADSProyect.Models
{
    public class Carrera
    {
        private int idCarrera;
        private string codigoCarrera;
        private string nombreCarrera;

        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string CodigoCarrera { get => codigoCarrera; set => codigoCarrera = value; }
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
    }
}
