using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Aplicacion.Request
{
  
            //Primary Constructor
        public record CrearAlumno(string Nombre, string Apellido, string Email, int Edad);
        //{
        //    public string Nombre { get; private set; }
        //    public string Apellido { get; init; }
        //    public string Email { get; set; }
        //    public int Edad { get; set; }
        //    public CrearAlumno(string nombre, string apellido, string email, int edad)
        //    {
        //        Nombre = nombre;
        //        Apellido = apellido;
        //        Email = email;
        //        Edad = edad;
        //    }
        //    public void metodo()
        //    {
        //        Nombre = "Juan";
        //        Apellido = "Perez";
        //    }
        //public override bool Equals(CrearAlumno obj)
        //{
        //    if(obj.Nombre == Nombre && obj.Apellido == Apellido)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //}

    
}
