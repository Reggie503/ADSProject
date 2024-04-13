using ADSProyect.Interfaces;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class ProfesorRepository : IProfesor
    {
        private List<Profesor> lstProfesor = new List<Profesor>
        {
            new Profesor{IdProfesor = 1, NombresProfesor = "Lester Balmore",
                        ApellidosProfesor = "Ortega Serrano", Email = "os24i04001@usonsonate.edu.sv"}
        };
        public int ActualizarProfesor(int idProfesor, Profesor profesor)
        {
            try
            {
                // Obtenemos el indice del objeto para actualizar
                int indice = lstProfesor.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                // Procedemos con la actualizacion.
                lstProfesor[indice] = profesor;

                return idProfesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarProfesor(Profesor profesor)
        {
            try
            {
                // Validar si existe datos en la lista, de ser asi tomaremos el ultimo ID
                // y lo incrementamos en una unidad
                if (lstProfesor.Count > 0)
                {
                    profesor.IdProfesor = lstProfesor.Last().IdProfesor + 1;
                }

                lstProfesor.Add(profesor);

                return profesor.IdProfesor;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarProfesor(int idProfesor)
        {
            try
            {
                // Obtenemos el indice del objeto para eliminar
                int indice = lstProfesor.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                // Procedemos a Eliminar
                lstProfesor.RemoveAt(indice);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Profesor ObtenerProfesorPorID(int idProfesor)
        {
            try
            {
                // Buscamos y asignamos el objeto estudiante
                Profesor profesor = lstProfesor.FirstOrDefault(tmp => tmp.IdProfesor == idProfesor);

                return profesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Profesor> ObtenerTodosLosProfesores()
        {
            try
            {
                return lstProfesor;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
