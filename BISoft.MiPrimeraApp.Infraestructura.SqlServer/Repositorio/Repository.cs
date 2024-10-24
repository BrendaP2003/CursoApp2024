using MyPrimeraApp.Contextos;
using MyPrimeraApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Repositorio
{
    public class Repository<QuienSabe> : IRepository<QuienSabe> where QuienSabe : Entidad
    {

        protected Context _contexto;

        public Repository(Context contexto)
        {
            _contexto = contexto;
        }


        public void Guardar(QuienSabe entidad)
        {
            entidad.Id = 0;
            //var result = _contexto.Set<QuienSabe>()
            //    .Where(x => x.Email )
            //    .FirstOrDefault();
            //if (result != null)
            //{
            //    return;
            //}
            _contexto.Set<QuienSabe>().Add(entidad);
            _contexto.SaveChanges();
        }

        public QuienSabe Obtener(int id)
        {
            return _contexto.Set<QuienSabe>().FirstOrDefault(x => x.Id == id);
        }

        public List<QuienSabe> Obtener()
        {
            return _contexto.Set<QuienSabe>().ToList();
        }
    }

}
