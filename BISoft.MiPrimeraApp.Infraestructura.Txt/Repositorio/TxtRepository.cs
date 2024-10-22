using MyPrimeraApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Infraestructura.Txt.Repositorio
{
    public class TxtRepository<T> : IRepository<T> where T : Entidad
    {
        //private readonly string _filePath;

        //public TxtRepository(string filePath)
        //{
        //    _filePath = filePath;
        //}

   

        public void Guardar(T entity) 
        {
            var filename = entity.GetType().Name;
            using (StreamWriter sw = new StreamWriter($"C:\\BaseDeDatos\\{entity.GetType().Name}.txt", true))
            {
                sw.WriteLine(entity.ToString()); // Asegúrate de que cada entidad tenga un método ToString adecuado
            }//:todo checar 
        }
       
        public T Obtener(int id)
        {
            return Obtener().FirstOrDefault(x => x.id == id);
        }
        public List<T> Obtener()
        {
            var entities = new List<T>();
            // Usa typeof(T).Name para obtener el nombre correcto del archivo
            using (StreamReader sr = new StreamReader($"C:\\BaseDeDatos\\{typeof(T).Name}.txt"))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    var entity = (T)Activator.CreateInstance(typeof(T));
                    entity.ReadTxt(linea);
                    entities.Add(entity);


                }
                return entities;

            }
        }
        // Método virtual para que las subclases lo implementen
        protected virtual T CrearEntidad(string linea)
        {
            throw new NotImplementedException("Este método debe ser implementado en las subclases.");
        }



        //public List<T> Obtener()
        //{
        //    var entities = new List<T>();
        //                                                               //entity.tostring{}
        //    using (StreamReader sr = new StreamReader($"C:\\BaseDeDatos\\Alumnos.txt"))//:todo falta modificar el nombre del archivo
        //    {
        //        string linea;
        //        while ((linea = sr.ReadLine()) != null)
        //        {

        //            var valores = linea.Split(',');
        //            if (typeof(T) == typeof(Alumno))
        //            {
        //                entities.Add((T)(object)new Alumno(valores[0], valores[1], valores[2]));
        //            }
        //            else if (typeof(T) == typeof(Maestro))
        //            {
        //                entities.Add((T)(object)new Maestro(valores[0], valores[1], valores[2], valores[3], valores[4]));
        //            }
        //        }
        //    }

        //    return entities;
        //}
    }
}



