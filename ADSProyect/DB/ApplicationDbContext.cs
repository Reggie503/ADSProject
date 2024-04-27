using ADSProject.Models;
using ADSProyect.Models;
using Microsoft.EntityFrameworkCore;

namespace ADSProyect.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        // Con un DbSet se indica a EntityFrameworkCoreccuales van a ser las tablas que yo quiero tenre
        // en la base de datos y tambien
        // le diremos en base a que modelos o entidades vamos a basar dichas tablas, por ejemplo

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Carrera> Carreras { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Grupo> Grupos { get; set; }

    }
}
