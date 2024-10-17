using MyPrimeraApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Infraestructura.Txt.Repositorio
{
    internal class TxtRepository
    {
    }
}

public class MaestroRepository : TxtRepository<Maestro>
{
    public MaestroRepository() : base("C:\\BaseDeDatos\\Maestros.txt") { }

    protected override Maestro ParseEntity(string linea)
    {
        var valores = linea.Split(',');
        return new Maestro(valores[1], valores[2], valores[3], valores[4], valores[5]) { Id = int.Parse(valores[0]) };
    }
}
