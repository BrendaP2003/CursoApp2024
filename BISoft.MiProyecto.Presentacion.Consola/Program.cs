// See https://aka.ms/new-console-template for more information







using BISoft.MiPrimeraApp.Aplicacion.Fabrica;
using BISoft.MiPrimeraApp.Infraestructura.Txt.Repositorio;
using MyPrimeraApp.Repositorio;

var service = ServiceFactory.CrearAlumnoService();






Console.WriteLine("Hello, World!");

var maestrotxt= new MaestroTxtRepository();
var maestros=maestrotxt.Obtener();
foreach (var item in maestros)
{
    Console.WriteLine(item);
    
}
Console.ReadLine();
