using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Aplicacion.Response
{
    public record MaestroDto(int Id, string Nombre, string Apellido, string Email, string Direccion, string Telefono);
    
}
