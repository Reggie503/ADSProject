﻿using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Migrations;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        /*private List<Estudiante> lstEstudiantes = new List<Estudiante>
        {
            new Estudiante{IdEstudiante = 1, NombreEstudiante = "Lester Balmore", 
                           ApellidoEstudiante = "Ortega Serrano", CodigoEstudiante = "OS24I04001", 
                           CorreoEstudiante = "os24i04001@usonsonate.edu.sv"}
        };*/
        private readonly ApplicationDbContext applicationDbContext;

        public EstudianteRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try
            {
                /*// Obtenemos el indice del objeto para actualizar
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                // Procedemos con la actualizacion.
                lstEstudiantes[indice] = estudiante;*/

                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.IdEstudiante == idEstudiante);

                applicationDbContext.Entry(item).CurrentValues.SetValues(estudiante);

                applicationDbContext.SaveChanges();

                return idEstudiante;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                /*// Validar si existe datos en la lista, de ser asi tomaremos el ultimo ID
                // y lo incrementamos en una unidad
                if (lstEstudiantes.Count > 0)
                {
                    estudiante.IdEstudiante = lstEstudiantes.Last().IdEstudiante + 1;
                }

                lstEstudiantes.Add(estudiante);*/

                applicationDbContext.Estudiantes.Add(estudiante);
                applicationDbContext.SaveChanges();

                return estudiante.IdEstudiante;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            try
            {
                /*// Obtenemos el indice del objeto para eliminar
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                // Procedemos a Eliminar
                lstEstudiantes.RemoveAt(indice);*/

                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.IdEstudiante == idEstudiante);

                applicationDbContext.Estudiantes.Remove(item);

                applicationDbContext.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante ObtenerEstudiantePorID(int idEstudiante)
        {
            try
            {
                /*// Buscamos y asignamos el objeto estudiante
                Estudiante estudiante = lstEstudiantes.FirstOrDefault(tmp => tmp.IdEstudiante == idEstudiante);*/

                var estudiante = applicationDbContext.Estudiantes.SingleOrDefault(x => x.IdEstudiante == idEstudiante);

                return estudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Estudiante> ObtenerTodosLosEstudiante()
        {
            try
            {
                return applicationDbContext.Estudiantes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
