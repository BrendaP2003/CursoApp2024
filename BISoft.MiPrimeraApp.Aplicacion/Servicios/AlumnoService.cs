using MyPrimeraApp.Entidades;
using MyPrimeraApp.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Aplicacion.Servicios
{
    public class AlumnoService
    {


        private readonly IAlumnoRepository _repo;

        public AlumnoService(IAlumnoRepository repo)
        {
            _repo = repo;
        }

        public Alumno CrearAlumno(string nombre, string apellido, string email)
        {
            var existeAlumno = _repo.Obtener().Any(x => x.Email == email);
            if (existeAlumno)
            {
                throw new Exception("El alumno ya existe");
            }

            var alumno = new Alumno(nombre, apellido, email);
            _repo.Guardar(alumno);

            return alumno;
        }
        public List<Alumno> ObtenerAlumnos()
        {
            return _repo.Obtener();
        }
    }
}
