using MyPrimeraApp.Entidades;

namespace MyPrimeraApp.Repositorio
{
    public class AlumnoTxtRepository : IAlumnoRepository
    {

        public void Guardar(Alumno alumno)
        {
            ////Validar que el alumno no existe
            //if (Obtener().Any(x => x.Email == alumno.Email))
            //{
            //    throw new InvalidOperationException(  "El alumno ya existe");
            //}

            using (StreamWriter sw = new StreamWriter("C:\\BaseDeDatos\\Alumnos.txt", true))
            {
                sw.WriteLine(alumno.Nombre + "," + alumno.Apellido + "," + alumno.Edad);
            }
        }

        public Alumno Obtener(int id)
        {
            return Obtener().FirstOrDefault(x => x.id == id);
        }

        public List<Alumno> Obtener()
        {

            var alumnos = new List<Alumno>();

            using (StreamReader sr = new StreamReader("C:\\BaseDeDatos\\Alumnos.txt"))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    var valores = linea.Split(',');

                    var alumno = new Alumno(valores[0], valores[1],valores[2], int.Parse(valores[2]));

                    alumnos.Add(alumno);

                   
                }
            }

            return alumnos;
        }
    }
}
