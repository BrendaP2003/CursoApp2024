using Microsoft.EntityFrameworkCore;
using MyPrimeraApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Contextos
{
    public class Context : DbContext
    {

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Maestro> Maestros { get; internal set; }

        public Context(DbContextOptions options): base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;database = Escuela;Encrypt=false; Trusted_connection=true");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>().HasKey(x => x.id);
            modelBuilder.Entity<Maestro>().HasKey(x => x.id);
        }
    }
}
