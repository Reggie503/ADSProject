using ADSProyect.Interfaces;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class CarreraRepository : ICarrera
    {
        private List<Carrera> lstCarrera= new List<Carrera>
        {
            new Carrera{IdCarrera = 1, CodigoCarrera = "ADS",
                           NombreCarrera = "Analisis de Sistemas"}
        };
        public int ActualizarCarrera(int idCarrera, Carrera carrera)
        {
            try
            {
                // Obtenemos el indice del objeto para actualizar
                int indice = lstCarrera.FindIndex(tmp => tmp.IdCarrera == idCarrera);

                // Procedemos con la actualizacion.
                lstCarrera[indice] = carrera;

                return idCarrera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                // Validar si existe datos en la lista, de ser asi tomaremos el ultimo ID
                // y lo incrementamos en una unidad
                if (lstCarrera.Count > 0)
                {
                    carrera.IdCarrera = lstCarrera.Last().IdCarrera + 1;
                }

                lstCarrera.Add(carrera);

                return carrera.IdCarrera;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarCarrera(int idCarrera)
        {
            try
            {
                // Obtenemos el indice del objeto para eliminar
                int indice = lstCarrera.FindIndex(tmp => tmp.IdCarrera == idCarrera);

                // Procedemos a Eliminar
                lstCarrera.RemoveAt(indice);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Carrera ObtenerCarreraPorId(int idCarrera)
        {
            try
            {
                // buscamos y asignamos el objeto estudiante 
                Carrera carrera = lstCarrera.FirstOrDefault(tmp => tmp.IdCarrera == idCarrera);

                return carrera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Carrera> ObtenerTodasLasCarreras()
        {
            try
            {
                return lstCarrera;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
