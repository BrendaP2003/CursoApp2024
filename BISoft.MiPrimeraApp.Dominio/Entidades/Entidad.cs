using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Entidades
{
    public class Entidad
    {
        public string Email { get; set; }
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Entidad()
        {
            
        }
        public virtual void ReadTxt(string linea)
        {
           
        }
    }
    
}
