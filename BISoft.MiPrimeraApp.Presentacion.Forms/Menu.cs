using Microsoft.EntityFrameworkCore;
using MyPrimeraApp.Contextos;
using MyPrimeraApp.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.SqlServer;
using MyPrimeraApp.Fabrica;
using static MyPrimeraApp.Fabrica.RepositoryFactory;
using BISoft.MiPrimeraApp.Aplicacion.Servicios;
using BISoft.MiPrimeraApp.Aplicacion.Fabrica;
using MyPrimeraApp.Helpers;

namespace MyPrimeraApp
{
    public partial class Menu : Form
    {

        private readonly AppContexto _appContext;


        public Menu()
        {
            InitializeComponent();

            _appContext = AppContexto.Instance(DBType.Sqlite);

        }


        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            //var repoSql = AlumnoRepositoryFactory
            //    .CrearAlumnoRepository(DBType.Sqlite);
            //    //new AlumnoRepository(context);

            // _appContext = AppContexto.Instance(DBType.Txt);

            var repoSql = RepositoryFactory
                .CrearAlumnoRepository(DBType.Sqlite);
            //new AlumnoRepository(context);
            var servicio = ServiceFactory.CrearAlumnoService(DBType.Sqlite);

            var form = new frmAlumnos(servicio);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repoSql = RepositoryFactory
                .CrearMaestroRepository(DBType.Txt);
            // new AlumnoRepository(context);
            var servicio2 = ServiceFactory.CrearMaestroService(DBType.Txt);
            var form = new frmMaestros(servicio2);
            form.Show();
        }
    }
}
