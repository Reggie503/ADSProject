﻿using ADSProyect.Models;

namespace ADSProyect.Interfaces
{
    public interface IEstudiante
    {
        public int AgregarEstudiante(Estudiante estudiante);
        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante);
        public bool EliminarEstudiante(int idEstudiante);
        public List<Estudiante> ObtenerTodosLosEstudiante();
        public Estudiante ObtenerEstudiantePorID(int idEstudiante);
    }
}
