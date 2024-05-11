using ADSProject.Interfaces;
using ADSProject.Models;
using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Models;

namespace ADSProject.Repositories
{
	public class MateriaRepository : IMateria
	{
        /*private List<Materia> lstMaterias = new List<Materia>
		{
			new Materia{IdMateria = 1, NombreMateria = "Estatica"}
		};*/

        private readonly ApplicationDbContext applicationDbContext;

        public MateriaRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int ActualizarMateria(int idMateria, Materia materia)
		{
			try
			{
                /*//Obtener el indice del Objeto para actualizar 
				int indice = lstMaterias.FindIndex(tmp => tmp.IdMateria == idMateria);

				//procedemos con la actualizacion
				lstMaterias[indice] = materia;*/

                var item = applicationDbContext.Materias.SingleOrDefault(x => x.IdMateria == idMateria);

                applicationDbContext.Entry(item).CurrentValues.SetValues(materia);

                applicationDbContext.SaveChanges();

                return idMateria;
			}
			catch (Exception)
			{
				throw;
			}
		}
		public int AgregarMateria(Materia materia)
		{
			try
			{
				//validar si existen datos en la lista, debe se asi, tomaremos el ultimo ID
				// y lo incrementamos en una unidad 
				/*if (lstMaterias.Count > 0)
				{
					materia.IdMateria = lstMaterias.Last().IdMateria + 1;
				}
				lstMaterias.Add(materia);*/

				applicationDbContext.Materias.Add(materia);
                applicationDbContext.SaveChanges();

                return materia.IdMateria;
			}
			catch (Exception)
			{
				throw;
			}
		}
		public bool EliminarMateria(int idMateria)
		{
			try
			{
                //Obtener el indice del Objeto para Eliminar 
                /*int indice = lstMaterias.FindIndex(tmp => tmp.IdMateria == idMateria);

				//procedemos a eliminar el registro
				lstMaterias.RemoveAt(indice);*/

                var item = applicationDbContext.Materias.SingleOrDefault(x => x.IdMateria == idMateria);

                applicationDbContext.Materias.Remove(item);

                applicationDbContext.SaveChanges();

                return true;


			}
			catch (Exception)
			{
				throw;
			}

		}

		public Materia ObtenerMateriaPorID(int idMateria)
		{
			try
			{

                //Materia materia = lstMaterias.FirstOrDefault(tmp => tmp.IdMateria == idMateria);

                var materia = applicationDbContext.Materias.SingleOrDefault(x => x.IdMateria == idMateria);

                return materia;


			}
			catch (Exception)
			{
				throw;
			}
		}
		public List<Materia> ObtenerTodosLasMaterias()
		{
			try
			{
                //return lstMaterias;
                return applicationDbContext.Materias.ToList();
            }
			catch (Exception)
			{
				throw;
			}
		}
	}


}