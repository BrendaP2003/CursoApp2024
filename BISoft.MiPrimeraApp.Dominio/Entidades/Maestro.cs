using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Entidades
{
    public class Maestro:Entidad
    {
      
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        

        public Maestro(string nombre, string apellido, string email, string direcion, string telefono )
        { 
           Nombre= nombre;
            Apellido= apellido;
            Email= email;
            Direccion= direcion;
            Telefono = telefono;

            //usar regex para validar email
            if (string.IsNullOrEmpty(email) && !email.Contains("@"))
            {
                throw new InvalidOperationException("El email no es valido");
            }

            Email = email;

        }
    }
}
