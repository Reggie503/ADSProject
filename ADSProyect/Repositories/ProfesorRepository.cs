using ADSProject.Interfaces;
using ADSProject.Models;
using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class ProfesorRepository : IProfesor
    {
        /*private List<Profesor> lstProfesor = new List<Profesor>
        {
            new Profesor{IdProfesor = 1, NombresProfesor = "Lester Balmore",
                        ApellidosProfesor = "Ortega Serrano", Email = "os24i04001@usonsonate.edu.sv"}
        };*/

        private readonly ApplicationDbContext applicationDbContext;

        public ProfesorRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int ActualizarProfesor(int idProfesor, Profesor profesor)
        {
            try
            {
                /*// Obtenemos el indice del objeto para actualizar
                int indice = lstProfesor.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                // Procedemos con la actualizacion.
                lstProfesor[indice] = profesor;*/

                var item = applicationDbContext.Profesores.SingleOrDefault(x => x.IdProfesor == idProfesor);

                applicationDbContext.Entry(item).CurrentValues.SetValues(profesor);

                applicationDbContext.SaveChanges();

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
                /*if (lstProfesor.Count > 0)
                {
                    profesor.IdProfesor = lstProfesor.Last().IdProfesor + 1;
                }

                lstProfesor.Add(profesor);*/

                applicationDbContext.Profesores.Add(profesor);
                applicationDbContext.SaveChanges();

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
                /*// Obtenemos el indice del objeto para eliminar
                int indice = lstProfesor.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                // Procedemos a Eliminar
                lstProfesor.RemoveAt(indice);*/

                var item = applicationDbContext.Profesores.SingleOrDefault(x => x.IdProfesor == idProfesor);

                applicationDbContext.Profesores.Remove(item);

                applicationDbContext.SaveChanges();

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
                //Profesor profesor = lstProfesor.FirstOrDefault(tmp => tmp.IdProfesor == idProfesor);

                var profesor = applicationDbContext.Profesores.SingleOrDefault(x => x.IdProfesor == idProfesor);

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
                //return lstProfesor;
                return applicationDbContext.Profesores.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
