using MyPrimeraApp.Entidades;
using MyPrimeraApp.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Infraestructura.Txt.Repositorio
{
    public class MaestroTxtRepository : TxtRepository<Maestro>, IMaestroRepository
    {
        public MaestroTxtRepository() : base() // Si necesitas pasar una ruta, añádela aquí.
        {
        }

       
    }
}
